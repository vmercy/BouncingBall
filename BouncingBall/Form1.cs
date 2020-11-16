using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    
    public partial class Form1 : Form
    {
        int ballHeight = 30;
        int ballWidth = 30;
        int ballPosX = 50;
        int ballPosY = 50;

        int step = 10;

        bool Xdirection = true;
        bool Ydirection = true;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.OrangeRed, ballPosX , ballPosY, ballWidth, ballHeight);
        }

        private void updateCoordinats(object sender, EventArgs e)
        {
            if (ballPosX >= this.Width - ballWidth)
            {
                Xdirection = false;
            }

            if (ballPosX <= 0)
                Xdirection = true;

            if (ballPosY <= 0)
                Ydirection = true;

            if (ballPosY >= this.Height - ballHeight)
            {
                Ydirection = false;
            }

            if (Xdirection)
                ballPosX+=step;
            else
                ballPosX -= step;

            if (Ydirection)
                ballPosY += step;
            else
                ballPosY -= step;           

            this.Refresh();
            
        }
    }
}
