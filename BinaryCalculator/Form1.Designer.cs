namespace BinaryCalculator
{
    partial class BinaryCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinaryCalcForm));
            this.calc_display = new System.Windows.Forms.Label();
            this.key_0 = new System.Windows.Forms.Button();
            this.key_1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.octLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.two_complement = new System.Windows.Forms.Button();
            this.bitwise_xor = new System.Windows.Forms.Button();
            this.bitwise_or = new System.Windows.Forms.Button();
            this.bitwise_and = new System.Windows.Forms.Button();
            this.bitwise_not = new System.Windows.Forms.Button();
            this.shift_left = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.shift_right = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calc_display
            // 
            this.calc_display.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_display.Location = new System.Drawing.Point(0, 49);
            this.calc_display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calc_display.Name = "calc_display";
            this.calc_display.Size = new System.Drawing.Size(305, 31);
            this.calc_display.TabIndex = 1;
            this.calc_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calc_display.TextChanged += new System.EventHandler(this.label_Change);
            // 
            // key_0
            // 
            this.key_0.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_0.Location = new System.Drawing.Point(155, 210);
            this.key_0.Margin = new System.Windows.Forms.Padding(0);
            this.key_0.Name = "key_0";
            this.key_0.Size = new System.Drawing.Size(70, 35);
            this.key_0.TabIndex = 2;
            this.key_0.Text = "0";
            this.key_0.UseVisualStyleBackColor = true;
            this.key_0.Click += new System.EventHandler(this.buton0_Click);
            // 
            // key_1
            // 
            this.key_1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_1.Location = new System.Drawing.Point(80, 210);
            this.key_1.Margin = new System.Windows.Forms.Padding(0);
            this.key_1.Name = "key_1";
            this.key_1.Size = new System.Drawing.Size(70, 35);
            this.key_1.TabIndex = 3;
            this.key_1.Text = "1";
            this.key_1.UseVisualStyleBackColor = true;
            this.key_1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // clear
            // 
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clear.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(155, 10);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 35);
            this.clear.TabIndex = 4;
            this.clear.TabStop = false;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(230, 10);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 35);
            this.delete.TabIndex = 5;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 68);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            this.label1.Text = "HEX\r\n\r\nDEC\r\n\r\nOCT\r\n";
            // 
            // hexLabel
            // 
            this.hexLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.Location = new System.Drawing.Point(55, 89);
            this.hexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(97, 17);
            this.hexLabel.TabIndex = 7;
            // 
            // decLabel
            // 
            this.decLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decLabel.Location = new System.Drawing.Point(55, 116);
            this.decLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(97, 17);
            this.decLabel.TabIndex = 8;
            // 
            // octLabel
            // 
            this.octLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octLabel.Location = new System.Drawing.Point(55, 141);
            this.octLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.octLabel.Name = "octLabel";
            this.octLabel.Size = new System.Drawing.Size(97, 17);
            this.octLabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 49);
            this.label2.TabIndex = 10;
            this.label2.Text = "BINARY CALCULATOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.two_complement);
            this.panel1.Controls.Add(this.bitwise_xor);
            this.panel1.Controls.Add(this.bitwise_or);
            this.panel1.Controls.Add(this.bitwise_and);
            this.panel1.Controls.Add(this.bitwise_not);
            this.panel1.Controls.Add(this.shift_left);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.substract);
            this.panel1.Controls.Add(this.multiply);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.shift_right);
            this.panel1.Controls.Add(this.key_0);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.key_1);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 251);
            this.panel1.TabIndex = 12;
            // 
            // two_complement
            // 
            this.two_complement.FlatAppearance.BorderSize = 0;
            this.two_complement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.two_complement.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_complement.Location = new System.Drawing.Point(80, 50);
            this.two_complement.Margin = new System.Windows.Forms.Padding(2);
            this.two_complement.Name = "two_complement";
            this.two_complement.Size = new System.Drawing.Size(70, 35);
            this.two_complement.TabIndex = 17;
            this.two_complement.TabStop = false;
            this.two_complement.Text = "CMP2";
            this.two_complement.UseVisualStyleBackColor = true;
            this.two_complement.Click += new System.EventHandler(this.two_complement_Click);
            // 
            // bitwise_xor
            // 
            this.bitwise_xor.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitwise_xor.Location = new System.Drawing.Point(155, 170);
            this.bitwise_xor.Margin = new System.Windows.Forms.Padding(0);
            this.bitwise_xor.Name = "bitwise_xor";
            this.bitwise_xor.Size = new System.Drawing.Size(70, 35);
            this.bitwise_xor.TabIndex = 16;
            this.bitwise_xor.Text = "XOR";
            this.bitwise_xor.UseVisualStyleBackColor = true;
            this.bitwise_xor.Click += new System.EventHandler(this.bitwise_xor_Click);
            // 
            // bitwise_or
            // 
            this.bitwise_or.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitwise_or.Location = new System.Drawing.Point(155, 130);
            this.bitwise_or.Margin = new System.Windows.Forms.Padding(0);
            this.bitwise_or.Name = "bitwise_or";
            this.bitwise_or.Size = new System.Drawing.Size(70, 35);
            this.bitwise_or.TabIndex = 15;
            this.bitwise_or.Text = "OR";
            this.bitwise_or.UseVisualStyleBackColor = true;
            this.bitwise_or.Click += new System.EventHandler(this.bitwise_or_Click);
            // 
            // bitwise_and
            // 
            this.bitwise_and.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitwise_and.Location = new System.Drawing.Point(155, 90);
            this.bitwise_and.Margin = new System.Windows.Forms.Padding(0);
            this.bitwise_and.Name = "bitwise_and";
            this.bitwise_and.Size = new System.Drawing.Size(70, 35);
            this.bitwise_and.TabIndex = 14;
            this.bitwise_and.Text = "AND";
            this.bitwise_and.UseVisualStyleBackColor = true;
            this.bitwise_and.Click += new System.EventHandler(this.bitwise_and_Click);
            // 
            // bitwise_not
            // 
            this.bitwise_not.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitwise_not.Location = new System.Drawing.Point(155, 50);
            this.bitwise_not.Margin = new System.Windows.Forms.Padding(0);
            this.bitwise_not.Name = "bitwise_not";
            this.bitwise_not.Size = new System.Drawing.Size(70, 35);
            this.bitwise_not.TabIndex = 13;
            this.bitwise_not.Text = "NOT";
            this.bitwise_not.UseVisualStyleBackColor = true;
            this.bitwise_not.Click += new System.EventHandler(this.bitwise_not_Click);
            // 
            // shift_left
            // 
            this.shift_left.FlatAppearance.BorderSize = 0;
            this.shift_left.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.shift_left.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_left.Location = new System.Drawing.Point(5, 10);
            this.shift_left.Margin = new System.Windows.Forms.Padding(2);
            this.shift_left.Name = "shift_left";
            this.shift_left.Size = new System.Drawing.Size(70, 35);
            this.shift_left.TabIndex = 12;
            this.shift_left.TabStop = false;
            this.shift_left.Text = "<<";
            this.shift_left.UseVisualStyleBackColor = true;
            this.shift_left.Click += new System.EventHandler(this.shift_left_Click);
            // 
            // equal
            // 
            this.equal.FlatAppearance.BorderSize = 0;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.equal.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(230, 210);
            this.equal.Margin = new System.Windows.Forms.Padding(2);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(70, 35);
            this.equal.TabIndex = 11;
            this.equal.TabStop = false;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // add
            // 
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(230, 170);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 35);
            this.add.TabIndex = 10;
            this.add.TabStop = false;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // substract
            // 
            this.substract.FlatAppearance.BorderSize = 0;
            this.substract.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.substract.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substract.Location = new System.Drawing.Point(230, 130);
            this.substract.Margin = new System.Windows.Forms.Padding(2);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(70, 35);
            this.substract.TabIndex = 9;
            this.substract.TabStop = false;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.substract_Click);
            // 
            // multiply
            // 
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.multiply.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(230, 90);
            this.multiply.Margin = new System.Windows.Forms.Padding(2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 35);
            this.multiply.TabIndex = 8;
            this.multiply.TabStop = false;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.divide.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(230, 50);
            this.divide.Margin = new System.Windows.Forms.Padding(2);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(70, 35);
            this.divide.TabIndex = 7;
            this.divide.TabStop = false;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // shift_right
            // 
            this.shift_right.FlatAppearance.BorderSize = 0;
            this.shift_right.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.shift_right.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_right.Location = new System.Drawing.Point(80, 10);
            this.shift_right.Margin = new System.Windows.Forms.Padding(2);
            this.shift_right.Name = "shift_right";
            this.shift_right.Size = new System.Drawing.Size(70, 35);
            this.shift_right.TabIndex = 6;
            this.shift_right.TabStop = false;
            this.shift_right.Text = ">>";
            this.shift_right.UseVisualStyleBackColor = true;
            this.shift_right.Click += new System.EventHandler(this.shift_right_Click);
            // 
            // BinaryCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.octLabel);
            this.Controls.Add(this.decLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc_display);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 457);
            this.Name = "BinaryCalcForm";
            this.Text = "Binary Calc";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label calc_display;
        private System.Windows.Forms.Button key_0;
        private System.Windows.Forms.Button key_1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.Label octLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button shift_right;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button shift_left;
        private System.Windows.Forms.Button bitwise_xor;
        private System.Windows.Forms.Button bitwise_or;
        private System.Windows.Forms.Button bitwise_and;
        private System.Windows.Forms.Button bitwise_not;
        private System.Windows.Forms.Button two_complement;
    }
}

