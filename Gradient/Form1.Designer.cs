namespace Gradient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_B = new System.Windows.Forms.Button();
            this.Result_DGV = new System.Windows.Forms.DataGridView();
            this.Step_TB = new System.Windows.Forms.TextBox();
            this.LevelTarget_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Regressor_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Graphic_PB = new System.Windows.Forms.PictureBox();
            this.Index_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gradient_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quality_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_B
            // 
            this.Start_B.Location = new System.Drawing.Point(296, 12);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(188, 20);
            this.Start_B.TabIndex = 0;
            this.Start_B.Text = "Calculate";
            this.Start_B.UseVisualStyleBackColor = true;
            this.Start_B.Click += new System.EventHandler(this.Start_B_Click);
            // 
            // Result_DGV
            // 
            this.Result_DGV.AllowUserToAddRows = false;
            this.Result_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result_DGV.BackgroundColor = System.Drawing.Color.White;
            this.Result_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Result_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index_C,
            this.Lot_C,
            this.Level_C,
            this.Gradient_C,
            this.Quality_C,
            this.Column1});
            this.Result_DGV.Location = new System.Drawing.Point(12, 38);
            this.Result_DGV.Name = "Result_DGV";
            this.Result_DGV.ReadOnly = true;
            this.Result_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Result_DGV.RowHeadersVisible = false;
            this.Result_DGV.RowHeadersWidth = 20;
            this.Result_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Result_DGV.RowTemplate.Height = 16;
            this.Result_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Result_DGV.ShowEditingIcon = false;
            this.Result_DGV.Size = new System.Drawing.Size(472, 209);
            this.Result_DGV.TabIndex = 1;
            // 
            // Step_TB
            // 
            this.Step_TB.Location = new System.Drawing.Point(47, 12);
            this.Step_TB.Name = "Step_TB";
            this.Step_TB.Size = new System.Drawing.Size(48, 20);
            this.Step_TB.TabIndex = 2;
            this.Step_TB.Text = "10";
            // 
            // LevelTarget_TB
            // 
            this.LevelTarget_TB.Location = new System.Drawing.Point(127, 12);
            this.LevelTarget_TB.Name = "LevelTarget_TB";
            this.LevelTarget_TB.Size = new System.Drawing.Size(48, 20);
            this.LevelTarget_TB.TabIndex = 4;
            this.LevelTarget_TB.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "LT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Step";
            // 
            // Regressor_TB
            // 
            this.Regressor_TB.Location = new System.Drawing.Point(242, 12);
            this.Regressor_TB.Name = "Regressor_TB";
            this.Regressor_TB.Size = new System.Drawing.Size(48, 20);
            this.Regressor_TB.TabIndex = 8;
            this.Regressor_TB.Text = "2.718281828";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Regressor";
            // 
            // Graphic_PB
            // 
            this.Graphic_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graphic_PB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Graphic_PB.Location = new System.Drawing.Point(12, 253);
            this.Graphic_PB.Name = "Graphic_PB";
            this.Graphic_PB.Size = new System.Drawing.Size(472, 367);
            this.Graphic_PB.TabIndex = 14;
            this.Graphic_PB.TabStop = false;
            // 
            // Index_C
            // 
            this.Index_C.HeaderText = "№";
            this.Index_C.Name = "Index_C";
            this.Index_C.ReadOnly = true;
            this.Index_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index_C.Width = 32;
            // 
            // Lot_C
            // 
            this.Lot_C.HeaderText = "Lot";
            this.Lot_C.Name = "Lot_C";
            this.Lot_C.ReadOnly = true;
            this.Lot_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lot_C.Width = 64;
            // 
            // Level_C
            // 
            this.Level_C.HeaderText = "Level";
            this.Level_C.Name = "Level_C";
            this.Level_C.ReadOnly = true;
            this.Level_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Level_C.Width = 64;
            // 
            // Gradient_C
            // 
            this.Gradient_C.HeaderText = "Step";
            this.Gradient_C.Name = "Gradient_C";
            this.Gradient_C.ReadOnly = true;
            this.Gradient_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gradient_C.Width = 64;
            // 
            // Quality_C
            // 
            this.Quality_C.HeaderText = "Level Step";
            this.Quality_C.Name = "Quality_C";
            this.Quality_C.ReadOnly = true;
            this.Quality_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quality_C.Width = 88;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 632);
            this.Controls.Add(this.Graphic_PB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regressor_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelTarget_TB);
            this.Controls.Add(this.Step_TB);
            this.Controls.Add(this.Result_DGV);
            this.Controls.Add(this.Start_B);
            this.MinimumSize = new System.Drawing.Size(512, 160);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_B;
        private System.Windows.Forms.TextBox Step_TB;
        private System.Windows.Forms.TextBox LevelTarget_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Result_DGV;
        private System.Windows.Forms.TextBox Regressor_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Graphic_PB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gradient_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quality_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

