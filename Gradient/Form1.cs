using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Gradient
{
    //https://ru.coursera.org/lecture/machine-learning-foundations/gradiientnyi-spusk-Cws8c
    //https://www.coursera.org/lecture/machine-learning-foundations/gradiientnyi-spusk-prodolzhieniie-TV3n1
    //https://www.coursera.org/lecture/machine-learning-foundations/gradiient-i-iegho-svoistva-oaHBN

    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private class LevelIteration
        {
            public double Lot { get; private set; }
            public double Level { get; private set; }

            public LevelIteration(double lot, Func<double, double> function)
            {
                Lot = lot;
                Level = function(Lot);
            }
        }

        private void Start_B_Click(object sender, EventArgs ea)
        {
            Result_DGV.Rows.Clear();

            var iteretionList = new List<LevelIteration>();
            int index = 0;
            double lot = 0.01;
            double levelTarget = LevelTarget_TB.Text.ToDouble();
            double stepLevel = Step_TB.Text.ToDouble();
            double regressor = Regressor_TB.Text.ToDouble();

            var iterationLast = new LevelIteration(lot, Function);

            iteretionList.Add(iterationLast);
            Result_DGV.Rows.Add
            (
                index,
                Math.Round(iterationLast.Lot, 2),
                Math.Round(iterationLast.Level, 0),
                "-",
                "-"
            );

            index++;
            while (true)
            {
                if (index >= 20)
                    break;

                if (iterationLast.Level <= levelTarget && iterationLast.Level >= 0)
                    break;

                if (iterationLast.Level >= -levelTarget && iterationLast.Level <= 0)
                    break;

                if (iteretionList.Count > 1)
                    if (iterationLast.Lot.Compare(iteretionList[iteretionList.Count - 2].Lot, "=="))
                        break;

                LevelIteration iterationNew;

                if (iterationLast.Level < 0 && iteretionList.Count > 1)
                {
                    if (iteretionList[iteretionList.Count - 2].Level > 0)
                    {
                        var iterationBad = iterationLast;
                        var iterationGood = iteretionList[iteretionList.Count - 2];

                        var l1 = iterationBad.Lot;
                        var l2 = iterationGood.Lot;

                        var L1 = iterationBad.Level;
                        var L2 = iterationGood.Level;

                        var DL1 = Math.Abs(levelTarget - L1);
                        var DL2 = Math.Abs(levelTarget - L2);

                        var lotNew = Math.Round((DL2 * l1 + DL1 * l2) / (DL1 + DL2), 2);
                        iterationNew = new LevelIteration(lotNew, Function);

                        stepLevel = Math.Round(lotNew - lot, 2, MidpointRounding.AwayFromZero);

                        if (stepLevel < 0.01)
                            stepLevel = 0.01;

                        lot = lotNew;
                    }
                    else
                    {
                        stepLevel = Math.Round(stepLevel / regressor, 2, MidpointRounding.AwayFromZero);

                        if (stepLevel < 0.01)
                            stepLevel = 0.01;

                        iterationNew = new LevelIteration(lot + stepLevel, Function);
                    }
                }
                else if (iterationLast.Level < 0)
                {
                    stepLevel = Math.Round(stepLevel / regressor, 2, MidpointRounding.AwayFromZero);

                    if (stepLevel < 0.01)
                        stepLevel = 0.01;

                    iterationNew = new LevelIteration(lot + stepLevel, Function);
                }
                else
                {
                    iterationNew = new LevelIteration(lot + stepLevel, Function);
                    if (iterationNew.Level > 0)
                        lot = Math.Round(lot + stepLevel, 2, MidpointRounding.AwayFromZero);
                }

                Result_DGV.Rows.Add
                (
                    index,
                    Math.Round(iterationNew.Lot, 2),
                    Math.Round(iterationNew.Level, 0),
                    Math.Round(stepLevel, 2),
                    Math.Round(iterationNew.Level - iterationLast.Level, 2)
                );

                iterationLast = iterationNew;
                iteretionList.Add(iterationLast);

                Graphic(iteretionList, levelTarget);
                Refresh();

                index++;
            }

            iteretionList.Add(iterationLast);
            Graphic(iteretionList, levelTarget);
        }

        private void Graphic (List<LevelIteration> list, double levelTarget)
        {
            var lineGraphic = new Pen(new SolidBrush(Color.Red), 1f);
            var lineMetric = new Pen(new SolidBrush(Color.White), 1f);
            var lineZero = new Pen(new SolidBrush(Color.Blue), 1f);
            var pointGraphic = new Pen(new SolidBrush(Color.Red), 2f);
            var bmp = new Bitmap(Graphic_PB.Width, Graphic_PB.Height);
            var graphic = Graphics.FromImage(bmp);
            var timeStep = 16;
            var time = 0;
            var zero = Graphic_PB.Height / 2;
            var Ymax = list.Max(x => x.Level);
            var Ymin = list.Min(x => x.Level);
            var Yabs = 0d;

            if (Math.Abs(Ymax) >= Math.Abs(Ymin))
                Yabs = Ymax;
            else
                Yabs = Ymin;

            var scale = zero / Yabs;

            graphic.DrawLineHorizontal(lineZero, zero);
            graphic.DrawLineHorizontal(lineMetric, (float)(zero + levelTarget * scale));
            graphic.DrawLineHorizontal(lineMetric, (float)(zero - levelTarget * scale));

            for (var i = 0; i < list.Count - 1; i++)
            {
                var point1 = new Point(time, (int)Math.Round(zero + list[i].Level * scale, 0));
                var point2 = new Point(time + timeStep, (int)Math.Round(zero + list[i + 1].Level * scale, 0));

                try
                {
                    graphic.DrawPoint(pointGraphic, point1, 2f);
                    graphic.DrawLine(lineGraphic, point1, point2);
                }
                catch
                {
                    time += timeStep;
                    continue;
                }

                time += timeStep;
            }

            //graphic.DrawPoint(pointGraphic, new Point(time, (int)Math.Round(zero + list[list.Count - 1].Level * scale, 0)), 2f);
            if (Math.Abs(Ymax) < Math.Abs(Ymin))
                Graphic_PB.Image = bmp;
            else
            {
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Graphic_PB.Image = bmp;
            }
        }

        private double Function(double lot)
        {
            var first = random.NextDouble();

            double second;
            if (random.NextDouble() <= 0.1)
                second = -1000;
            else if (random.NextDouble() >= 0.9)
                second = 1000;
            else
                second = 0;

            return 100000 - lot * lot / (lot + lot + 1) * 1000 - lot - lot * lot * lot + lot * lot * first + second;
        }

        private bool LevelCheck(double limit, LevelIteration iteration)
        {
            return iteration.Level <= limit && iteration.Level >= 0;
        }
    }

    public static class Extentions
    {
        public static int ToInt(this string input)
        {
            string result;
            if (input.Contains(","))
            {
                var temporary = input.Split(',');
                result = temporary[0] + "." + temporary[1];
            }
            else
                result = input;
            return int.Parse(result, CultureInfo.InvariantCulture);
        }

        public static short ToShort(this string input)
        {
            string result;
            if (input.Contains(","))
            {
                var temporary = input.Split(',');
                result = temporary[0] + "." + temporary[1];
            }
            else
                result = input;
            return short.Parse(result, CultureInfo.InvariantCulture);
        }

        public static byte ToByte(this string input)
        {
            string result;
            if (input.Contains(","))
            {
                var temporary = input.Split(',');
                result = temporary[0] + "." + temporary[1];
            }
            else
                result = input;
            return byte.Parse(result, CultureInfo.InvariantCulture);
        }

        public static double ToDouble(this string input)
        {
            string result;
            if (input.Contains(","))
            {
                var temporary = input.Split(',');
                result = temporary[0] + "." + temporary[1];
            }
            else
                result = input;
            return double.Parse(result, CultureInfo.InvariantCulture);
        }

        public static float ToFloat(this string input)
        {
            string result;
            if (input.Contains(","))
            {
                var temporary = input.Split(',');
                result = temporary[0] + "." + temporary[1];
            }
            else
                result = input;
            return float.Parse(result, CultureInfo.InvariantCulture);
        }

        public static bool Compare(this double a, double b, string type)
        {
            switch (type)
            {
                case "==": return Math.Abs(a - b) <= double.Epsilon;
                case "!=": return Math.Abs(a - b) > double.Epsilon;
                case "<": return a < b - double.Epsilon;
                case "<=": return a <= b + double.Epsilon;
                case ">=": return a >= b - double.Epsilon;
                case ">": return a > b + double.Epsilon;
                default: throw new InvalidDataException();
            }
        }

        public static bool Compare(this float a, float b, string type)
        {
            switch (type)
            {
                case "==": return Math.Abs(a - b) <= float.Epsilon;
                case "!=": return Math.Abs(a - b) > float.Epsilon;
                case "<": return a < b - float.Epsilon;
                case "<=": return a <= b + float.Epsilon;
                case ">=": return a >= b - float.Epsilon;
                case ">": return a > b + float.Epsilon;
                default: throw new InvalidDataException();
            }
        }

        public static void DrawPoint(this Graphics graphic, Pen pen, float X, float Y, float size)
        {
            graphic.DrawEllipse(pen, new Rectangle() { X = (int)(X - size / 2), Y = (int)(Y - size / 2), Width = (int)size, Height = (int)size });
        }

        public static void DrawPoint(this Graphics graphic, Pen pen, Point point, float size)
        {
            graphic.DrawEllipse(pen, new Rectangle() { X = (int)(point.X - size / 2), Y = (int)(point.Y - size / 2), Width = (int)size, Height = (int)size });
        }

        public static void DrawLineHorizontal(this Graphics graphic, Pen pen, float Y)
        {
            try
            {
                graphic.DrawLine(pen, new Point(0, (int)Y), new Point((int)graphic.ClipBounds.Right, (int)Y));
            }
            catch { }
        }

        public static void DrawLineVerical(this Graphics graphic, Pen pen, float X)
        {
            graphic.DrawLine(pen, new Point((int)X, 0), new Point((int)X, (int)graphic.ClipBounds.Bottom));
        }
    }
}