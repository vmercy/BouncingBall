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
        int ballHeight = 100;
        int ballWidth = 100;
        int ballPosX = 0;
        int ballPosY = 0;

        bool Xdirection = true;
        bool Ydirection = true;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Blue, ballPosX , ballPosY, ballWidth, ballHeight);
        }

        private void updateCoordinats(object sender, EventArgs e)
        {
            if (ballPosX == this.Width - ballWidth)
            {
                Xdirection = false;
            }

            if (ballPosX == 0)
                Xdirection = true;

            if (ballPosY == 0)
                Ydirection = true;

            if (ballPosY == this.Height - ballHeight)
            {
                Ydirection = false;
            }

            if (Xdirection)
                ballPosX++;
            else
                ballPosX--;

            if (Ydirection)
                ballPosY++;
            else
                ballPosY--;           

            this.Refresh();
            
        }
    }
}
