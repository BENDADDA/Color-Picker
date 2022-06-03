using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Picker_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //the complexty time is O(1).
        Color AColor(int value, int p = 100)
        {
            int red, green, blue;
            int q, r;
            red = green = blue = 0;
            q = value / 256;
            r = value % 256;
            switch (q)
            {
                case 0: red = 255; green = r; blue = 0; break;
                case 1: red = 255 - r; green = 255; blue = 0; break;
                case 2: red = 0; green = 255; blue = r; break;
                case 3: red = 0; green = 255 - r; blue = 255; break;
                case 4: red = r; green = 0; blue = 255; break;
                case 5: red = 255; green = 0; blue = 255 - r; break;
            }
            if (p != 100)
            {
                red = red * p / 100;
                green = green * p / 100;
                blue = blue * p / 100;
            }
            return Color.FromArgb(red, green, blue);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = AColor(trackBar1.Value);
            
        }
    }
}
