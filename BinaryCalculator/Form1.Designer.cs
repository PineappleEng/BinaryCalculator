namespace BinaryCalculator
{
    partial class Form1
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
            this.layout = new System.Windows.Forms.Label();
            this.buton0 = new System.Windows.Forms.Button();
            this.buton1 = new System.Windows.Forms.Button();
            this.ereaseAll = new System.Windows.Forms.Button();
            this.ereaseDigit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.octLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Calculadora Binaria";
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.Location = new System.Drawing.Point(3, 50);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(408, 38);
            this.layout.TabIndex = 1;
            this.layout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.layout.TextChanged += new System.EventHandler(this.label_Change);
            // 
            // buton0
            // 
            this.buton0.Location = new System.Drawing.Point(59, 276);
            this.buton0.Name = "buton0";
            this.buton0.Size = new System.Drawing.Size(116, 55);
            this.buton0.TabIndex = 2;
            this.buton0.Text = "0";
            this.buton0.UseVisualStyleBackColor = true;
            this.buton0.Click += new System.EventHandler(this.buton0_Click);
            // 
            // buton1
            // 
            this.buton1.Location = new System.Drawing.Point(218, 290);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(143, 41);
            this.buton1.TabIndex = 3;
            this.buton1.Text = "1";
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // ereaseAll
            // 
            this.ereaseAll.Location = new System.Drawing.Point(246, 233);
            this.ereaseAll.Name = "ereaseAll";
            this.ereaseAll.Size = new System.Drawing.Size(94, 27);
            this.ereaseAll.TabIndex = 4;
            this.ereaseAll.Text = "delete";
            this.ereaseAll.UseVisualStyleBackColor = true;
            this.ereaseAll.Click += new System.EventHandler(this.ereaseAll_Click);
            // 
            // ereaseDigit
            // 
            this.ereaseDigit.Location = new System.Drawing.Point(59, 233);
            this.ereaseDigit.Name = "ereaseDigit";
            this.ereaseDigit.Size = new System.Drawing.Size(100, 24);
            this.ereaseDigit.TabIndex = 5;
            this.ereaseDigit.Text = "digit";
            this.ereaseDigit.UseVisualStyleBackColor = true;
            this.ereaseDigit.Click += new System.EventHandler(this.ereaseDigit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 103);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            this.label1.Text = "HEX\r\n\r\nDEC\r\n\r\nOCT\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hexLabel
            // 
            this.hexLabel.Location = new System.Drawing.Point(56, 127);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(129, 21);
            this.hexLabel.TabIndex = 7;
            // 
            // decLabel
            // 
            this.decLabel.Location = new System.Drawing.Point(56, 157);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(129, 21);
            this.decLabel.TabIndex = 8;
            // 
            // octLabel
            // 
            this.octLabel.Location = new System.Drawing.Point(56, 188);
            this.octLabel.Name = "octLabel";
            this.octLabel.Size = new System.Drawing.Size(129, 21);
            this.octLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 506);
            this.Controls.Add(this.octLabel);
            this.Controls.Add(this.decLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ereaseDigit);
            this.Controls.Add(this.ereaseAll);
            this.Controls.Add(this.buton1);
            this.Controls.Add(this.buton0);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label layout;
        private System.Windows.Forms.Button buton0;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Button ereaseAll;
        private System.Windows.Forms.Button ereaseDigit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.Label octLabel;
    }
}

