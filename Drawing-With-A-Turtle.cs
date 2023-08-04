using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_With_A_Turtle
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void buttonDrawing_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.Green;
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Trutle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(60);
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }

        }

        private void buttonTriangleLine_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.Green;
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }

        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Yellow;
            Turtle.Delay = 50;
            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(250);
                Turtle.Rotate(170);
            }
        }

        private void buttonSpiralTriangle_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Red;
            Turtle.Delay = 100;
            for (int i = 0; i < 22; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
            }
        }
    }
}
