namespace CSharpHomeWork1
{
    partial class Homework1_4
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
            this.textOrigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEncode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textOrigin
            // 
            this.textOrigin.Location = new System.Drawing.Point(12, 31);
            this.textOrigin.Multiline = true;
            this.textOrigin.Name = "textOrigin";
            this.textOrigin.Size = new System.Drawing.Size(629, 148);
            this.textOrigin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "原文";
            // 
            // textEncode
            // 
            this.textEncode.Location = new System.Drawing.Point(12, 210);
            this.textEncode.Multiline = true;
            this.textEncode.Name = "textEncode";
            this.textEncode.Size = new System.Drawing.Size(629, 148);
            this.textEncode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密文";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(16, 365);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(136, 56);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "加密";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 56);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Homework1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 448);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEncode);
            this.Controls.Add(this.textOrigin);
            this.Name = "Homework1_3";
            this.Text = "文本加密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEncode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnClear;
    }
}