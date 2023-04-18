namespace ColorGetter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.txtCompB = new System.Windows.Forms.TextBox();
            this.txtCompG = new System.Windows.Forms.TextBox();
            this.txtCompR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compColorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hex";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(53, 6);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(105, 20);
            this.txtHex.TabIndex = 1;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.White;
            this.colorBox.Location = new System.Drawing.Point(164, 6);
            this.colorBox.Multiline = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.ReadOnly = true;
            this.colorBox.Size = new System.Drawing.Size(444, 426);
            this.colorBox.TabIndex = 2;
            this.colorBox.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 405);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(65, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color!";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(53, 32);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(31, 20);
            this.txtR.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RGB";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(90, 32);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(31, 20);
            this.txtG.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(127, 32);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(31, 20);
            this.txtB.TabIndex = 7;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(90, 405);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(68, 23);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random!";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lstColors
            // 
            this.lstColors.FormattingEnabled = true;
            this.lstColors.Location = new System.Drawing.Point(12, 58);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(146, 342);
            this.lstColors.TabIndex = 9;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // txtCompB
            // 
            this.txtCompB.Location = new System.Drawing.Point(729, 58);
            this.txtCompB.Name = "txtCompB";
            this.txtCompB.Size = new System.Drawing.Size(31, 20);
            this.txtCompB.TabIndex = 15;
            // 
            // txtCompG
            // 
            this.txtCompG.Location = new System.Drawing.Point(692, 58);
            this.txtCompG.Name = "txtCompG";
            this.txtCompG.Size = new System.Drawing.Size(31, 20);
            this.txtCompG.TabIndex = 14;
            // 
            // txtCompR
            // 
            this.txtCompR.Location = new System.Drawing.Point(655, 58);
            this.txtCompR.Name = "txtCompR";
            this.txtCompR.Size = new System.Drawing.Size(31, 20);
            this.txtCompR.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "RGB";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(655, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hex";
            // 
            // compColorBox
            // 
            this.compColorBox.BackColor = System.Drawing.Color.White;
            this.compColorBox.Location = new System.Drawing.Point(617, 84);
            this.compColorBox.Multiline = true;
            this.compColorBox.Name = "compColorBox";
            this.compColorBox.ReadOnly = true;
            this.compColorBox.Size = new System.Drawing.Size(144, 348);
            this.compColorBox.TabIndex = 17;
            this.compColorBox.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 440);
            this.Controls.Add(this.compColorBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompB);
            this.Controls.Add(this.txtCompG);
            this.Controls.Add(this.txtCompR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.TextBox txtCompB;
        private System.Windows.Forms.TextBox txtCompG;
        private System.Windows.Forms.TextBox txtCompR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox compColorBox;
    }
}

