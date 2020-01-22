namespace vectedit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HighB = new System.Windows.Forms.RadioButton();
            this.LineB = new System.Windows.Forms.RadioButton();
            this.BezieB = new System.Windows.Forms.RadioButton();
            this.RectB = new System.Windows.Forms.RadioButton();
            this.ElliplseB = new System.Windows.Forms.RadioButton();
            this.TriB = new System.Windows.Forms.RadioButton();
            this.FillB = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 428);
            this.panel1.TabIndex = 0;
            // 
            // HighB
            // 
            this.HighB.AutoSize = true;
            this.HighB.Location = new System.Drawing.Point(12, 12);
            this.HighB.Name = "HighB";
            this.HighB.Size = new System.Drawing.Size(75, 17);
            this.HighB.TabIndex = 1;
            this.HighB.TabStop = true;
            this.HighB.Text = "Выделить";
            this.HighB.UseVisualStyleBackColor = true;
            // 
            // LineB
            // 
            this.LineB.AutoSize = true;
            this.LineB.Location = new System.Drawing.Point(12, 35);
            this.LineB.Name = "LineB";
            this.LineB.Size = new System.Drawing.Size(65, 17);
            this.LineB.TabIndex = 2;
            this.LineB.TabStop = true;
            this.LineB.Text = "Прямая";
            this.LineB.UseVisualStyleBackColor = true;
            // 
            // BezieB
            // 
            this.BezieB.AutoSize = true;
            this.BezieB.Location = new System.Drawing.Point(12, 58);
            this.BezieB.Name = "BezieB";
            this.BezieB.Size = new System.Drawing.Size(62, 17);
            this.BezieB.TabIndex = 3;
            this.BezieB.TabStop = true;
            this.BezieB.Text = "Кривая";
            this.BezieB.UseVisualStyleBackColor = true;
            // 
            // RectB
            // 
            this.RectB.AutoSize = true;
            this.RectB.Location = new System.Drawing.Point(12, 81);
            this.RectB.Name = "RectB";
            this.RectB.Size = new System.Drawing.Size(105, 17);
            this.RectB.TabIndex = 4;
            this.RectB.TabStop = true;
            this.RectB.Text = "Прямоугольник";
            this.RectB.UseVisualStyleBackColor = true;
            // 
            // ElliplseB
            // 
            this.ElliplseB.AutoSize = true;
            this.ElliplseB.Location = new System.Drawing.Point(12, 104);
            this.ElliplseB.Name = "ElliplseB";
            this.ElliplseB.Size = new System.Drawing.Size(62, 17);
            this.ElliplseB.TabIndex = 5;
            this.ElliplseB.TabStop = true;
            this.ElliplseB.Text = "Эллипс";
            this.ElliplseB.UseVisualStyleBackColor = true;
            // 
            // TriB
            // 
            this.TriB.AutoSize = true;
            this.TriB.Location = new System.Drawing.Point(12, 127);
            this.TriB.Name = "TriB";
            this.TriB.Size = new System.Drawing.Size(90, 17);
            this.TriB.TabIndex = 6;
            this.TriB.TabStop = true;
            this.TriB.Text = "Треугольник";
            this.TriB.UseVisualStyleBackColor = true;
            // 
            // FillB
            // 
            this.FillB.AutoSize = true;
            this.FillB.Location = new System.Drawing.Point(12, 150);
            this.FillB.Name = "FillB";
            this.FillB.Size = new System.Drawing.Size(68, 17);
            this.FillB.TabIndex = 7;
            this.FillB.TabStop = true;
            this.FillB.Text = "Заливка";
            this.FillB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.FillB);
            this.Controls.Add(this.TriB);
            this.Controls.Add(this.ElliplseB);
            this.Controls.Add(this.RectB);
            this.Controls.Add(this.BezieB);
            this.Controls.Add(this.LineB);
            this.Controls.Add(this.HighB);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton HighB;
        private System.Windows.Forms.RadioButton LineB;
        private System.Windows.Forms.RadioButton BezieB;
        private System.Windows.Forms.RadioButton RectB;
        private System.Windows.Forms.RadioButton ElliplseB;
        private System.Windows.Forms.RadioButton TriB;
        private System.Windows.Forms.RadioButton FillB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

