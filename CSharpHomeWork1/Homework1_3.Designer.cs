namespace CSharpHomeWork1
{
    partial class Homework1_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLetter = new System.Windows.Forms.Label();
            this.labelDigit = new System.Windows.Forms.Label();
            this.labelPunctuation = new System.Windows.Forms.Label();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelWhitespace = new System.Windows.Forms.Label();
            this.labelOther = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(708, 218);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "字符数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "数字数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "标点符号数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "符号数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "空白字符数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "其他符号数";
            // 
            // labelLetter
            // 
            this.labelLetter.AutoSize = true;
            this.labelLetter.Location = new System.Drawing.Point(179, 246);
            this.labelLetter.Name = "labelLetter";
            this.labelLetter.Size = new System.Drawing.Size(0, 15);
            this.labelLetter.TabIndex = 7;
            // 
            // labelDigit
            // 
            this.labelDigit.AutoSize = true;
            this.labelDigit.Location = new System.Drawing.Point(179, 271);
            this.labelDigit.Name = "labelDigit";
            this.labelDigit.Size = new System.Drawing.Size(0, 15);
            this.labelDigit.TabIndex = 8;
            // 
            // labelPunctuation
            // 
            this.labelPunctuation.AutoSize = true;
            this.labelPunctuation.Location = new System.Drawing.Point(179, 296);
            this.labelPunctuation.Name = "labelPunctuation";
            this.labelPunctuation.Size = new System.Drawing.Size(0, 15);
            this.labelPunctuation.TabIndex = 9;
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Location = new System.Drawing.Point(179, 323);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(0, 15);
            this.labelSymbol.TabIndex = 10;
            // 
            // labelWhitespace
            // 
            this.labelWhitespace.AutoSize = true;
            this.labelWhitespace.Location = new System.Drawing.Point(179, 351);
            this.labelWhitespace.Name = "labelWhitespace";
            this.labelWhitespace.Size = new System.Drawing.Size(0, 15);
            this.labelWhitespace.TabIndex = 11;
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(179, 380);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(0, 15);
            this.labelOther.TabIndex = 12;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(573, 246);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(147, 65);
            this.btnStatistics.TabIndex = 13;
            this.btnStatistics.Text = "分类统计";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(573, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 65);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Homework1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 409);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.labelOther);
            this.Controls.Add(this.labelWhitespace);
            this.Controls.Add(this.labelSymbol);
            this.Controls.Add(this.labelPunctuation);
            this.Controls.Add(this.labelDigit);
            this.Controls.Add(this.labelLetter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Homework1_3";
            this.Text = "字符统计";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLetter;
        private System.Windows.Forms.Label labelDigit;
        private System.Windows.Forms.Label labelPunctuation;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelWhitespace;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnClear;
    }
}