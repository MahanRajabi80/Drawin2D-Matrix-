using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_17_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------
        private void btnShow_Click(object sender, EventArgs e)
        {
            int x = panel1.Width / 2;
            int y = panel1.Height / 2;
            int number = int.Parse(txtNumber.Text);
            Pen p = new Pen(Color.Black);
            Graphics gr = panel1.CreateGraphics();
            gr.Clear(this.BackColor);
            System.Drawing.Drawing2D.Matrix myMatrix = new System.Drawing.Drawing2D.Matrix();
            for (int i = 1; i <= number; i++)
            {
                gr.DrawEllipse(p, panel1.Width-60, panel1.Height/2, 30, 30);
                myMatrix.RotateAt(360.0F/number, new Point(x, y));
                gr.Transform = myMatrix;
            }
            gr.Dispose();
        }
    }
}
