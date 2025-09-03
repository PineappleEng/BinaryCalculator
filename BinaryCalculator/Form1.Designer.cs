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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layout = new System.Windows.Forms.Label();
            this.buton0 = new System.Windows.Forms.Button();
            this.buton1 = new System.Windows.Forms.Button();
            this.ereaseAll = new System.Windows.Forms.Button();
            this.ereaseDigit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.octLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layout.Location = new System.Drawing.Point(2, 73);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(404, 38);
            this.layout.TabIndex = 1;
            this.layout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.layout.TextChanged += new System.EventHandler(this.label_Change);
            // 
            // buton0
            // 
            this.buton0.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton0.Location = new System.Drawing.Point(86, 0);
            this.buton0.Margin = new System.Windows.Forms.Padding(1);
            this.buton0.Name = "buton0";
            this.buton0.Size = new System.Drawing.Size(84, 57);
            this.buton0.TabIndex = 2;
            this.buton0.Text = "0";
            this.buton0.UseVisualStyleBackColor = true;
            this.buton0.Click += new System.EventHandler(this.buton0_Click);
            // 
            // buton1
            // 
            this.buton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton1.Location = new System.Drawing.Point(0, 0);
            this.buton1.Margin = new System.Windows.Forms.Padding(1);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(84, 57);
            this.buton1.TabIndex = 3;
            this.buton1.Text = "1";
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // ereaseAll
            // 
            this.ereaseAll.FlatAppearance.BorderSize = 0;
            this.ereaseAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ereaseAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ereaseAll.Location = new System.Drawing.Point(195, 214);
            this.ereaseAll.Name = "ereaseAll";
            this.ereaseAll.Size = new System.Drawing.Size(84, 57);
            this.ereaseAll.TabIndex = 4;
            this.ereaseAll.TabStop = false;
            this.ereaseAll.Text = "CE";
            this.ereaseAll.UseVisualStyleBackColor = true;
            this.ereaseAll.Click += new System.EventHandler(this.ereaseAll_Click);
            // 
            // ereaseDigit
            // 
            this.ereaseDigit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ereaseDigit.BackgroundImage")));
            this.ereaseDigit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ereaseDigit.Location = new System.Drawing.Point(285, 214);
            this.ereaseDigit.Name = "ereaseDigit";
            this.ereaseDigit.Size = new System.Drawing.Size(84, 57);
            this.ereaseDigit.TabIndex = 5;
            this.ereaseDigit.UseVisualStyleBackColor = true;
            this.ereaseDigit.Click += new System.EventHandler(this.ereaseDigit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 103);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            this.label1.Text = "HEX\r\n\r\nDEC\r\n\r\nOCT\r\n";
            // 
            // hexLabel
            // 
            this.hexLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.Location = new System.Drawing.Point(77, 125);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(129, 21);
            this.hexLabel.TabIndex = 7;
            // 
            // decLabel
            // 
            this.decLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decLabel.Location = new System.Drawing.Point(77, 159);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(129, 21);
            this.decLabel.TabIndex = 8;
            // 
            // octLabel
            // 
            this.octLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octLabel.Location = new System.Drawing.Point(77, 190);
            this.octLabel.Name = "octLabel";
            this.octLabel.Size = new System.Drawing.Size(129, 21);
            this.octLabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calculadora Binaria";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buton0);
            this.panel1.Controls.Add(this.buton1);
            this.panel1.Location = new System.Drawing.Point(70, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 111);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ereaseDigit);
            this.Controls.Add(this.ereaseAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.octLabel);
            this.Controls.Add(this.decLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.layout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 553);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label layout;
        private System.Windows.Forms.Button buton0;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Button ereaseAll;
        private System.Windows.Forms.Button ereaseDigit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.Label octLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

