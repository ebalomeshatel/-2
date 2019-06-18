namespace ШОК{
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
            this.Calculate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Rectangle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWigth = new System.Windows.Forms.TextBox();
            this.textHeigth_par = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(605, 246);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(122, 58);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Start";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(290, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 191);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 194);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(229, 191);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(12, 171);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(82, 20);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.Text = "Rectangle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parallelepiped";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(16, 60);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(100, 26);
            this.textHeight.TabIndex = 5;
            // 
            // textWigth
            // 
            this.textWigth.Location = new System.Drawing.Point(16, 117);
            this.textWigth.Name = "textWigth";
            this.textWigth.Size = new System.Drawing.Size(100, 26);
            this.textWigth.TabIndex = 6;
            // 
            // textHeigth_par
            // 
            this.textHeigth_par.Location = new System.Drawing.Point(290, 60);
            this.textHeigth_par.Name = "textHeigth_par";
            this.textHeigth_par.Size = new System.Drawing.Size(100, 26);
            this.textHeigth_par.TabIndex = 7;
            this.textHeigth_par.TextChanged += new System.EventHandler(this.textHeigth_par_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height of Parallelepiped";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHeigth_par);
            this.Controls.Add(this.textWigth);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label Rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWigth;
        private System.Windows.Forms.TextBox textHeigth_par;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

