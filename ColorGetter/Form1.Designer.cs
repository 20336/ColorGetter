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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 440);
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
    }
}

