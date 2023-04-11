using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGetter
{
    public partial class Form1 : Form
    {
        Random ran = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorSet();

        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            string[] hexCodes = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            
           
            string hex = hexCodes[ranInt(hexCodes.Length)] + hexCodes[ranInt(hexCodes.Length)] + hexCodes[ranInt(hexCodes.Length)] + hexCodes[ranInt(hexCodes.Length)] + hexCodes[ranInt(hexCodes.Length)] + hexCodes[ranInt(hexCodes.Length)];
            
            txtHex.Text = hex.ToString();
            colorSet();
        }

        private void colorSet()
        {
            string hex = txtHex.Text;

            lstColors.Items.Add(hex);

            string redString = hex.Substring(0, 2);
            string greenString = hex.Substring(2, 2);
            string blueString = hex.Substring(4);

            //convertToDecimal(redString);
            int red = convertToDecimal(redString);
            int green = convertToDecimal(greenString);
            int blue = convertToDecimal(blueString);

            txtR.Text = red.ToString();
            txtG.Text = green.ToString();
            txtB.Text = blue.ToString();
            colorBox.BackColor = Color.FromArgb(red, green, blue);
        }

        public int ranInt(int length)
        {
            return ran.Next(length);
        }

        private int convertToDecimal(string hexNum)
        {
            List<string> hexSp = new List<string>();
            foreach (char ch in hexNum)
            {
                hexSp.Add(ch.ToString());
            }
            switch (hexSp[0])
            {
                case "a":
                    hexSp[0] = "10";
                    break;
                case "b":
                    hexSp[0] = "11";
                    break;
                case "c":
                    hexSp[0] = "12";
                    break;
                case "d":
                    hexSp[0] = "13";
                    break;
                case "f":
                    hexSp[0] = "14";
                    break;
                case "e":
                    hexSp[0] = "15";
                    break;
            }
            switch (hexSp[1])
            {
                case "a":
                    hexSp[1] = "10";
                    break;
                case "b":
                    hexSp[1] = "11";
                    break;
                case "c":
                    hexSp[1] = "12";
                    break;
                case "d":
                    hexSp[1] = "13";
                    break;
                case "f":
                    hexSp[1] = "14";
                    break;
                case "e":
                    hexSp[1] = "15";
                    break;
            }
            
            int hexNum1 = Convert.ToInt32(hexSp[0]);
            int hexNum2 = Convert.ToInt32(hexSp[1]);

            int dec = (hexNum1 * 16) + (hexNum1 * 1);
            return dec;
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHex.Text = lstColors.Text.ToString();
        }
    }
}
