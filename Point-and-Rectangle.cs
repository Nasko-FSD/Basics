using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_and_Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draw();

        }

        private void Draw()
        {
            var x1 = this.numericUpDownx1.Value;
            var y1 = this.numericUpDowny1.Value;
            var x2 = this.numericUpDownx2.Value;
            var y2 = this.numericUpDowny2.Value;
            var x = this.numericUpDownx.Value;
            var y = this.numericUpDowny.Value;

            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var up = Math.Min(y1, y2);
            var down = Math.Max(y1, y2);

            if (x > left && x < right && y > up && y < down )
            {
                this.labelResult.Text = "Inside";
                this.labelResult.BackColor = Color.LightGreen;
            }
            else if (x < left || x > right || y < up || y > down)
            {
                this.labelResult.Text = "Outside";
                this.labelResult.BackColor = Color.OrangeRed;
            }
            else if ( 
                ((x == left || x == right)) && 
                ((y == up || y == down)))
            {
                this.labelResult.Text = "Corner";
                this.labelResult.BackColor = Color.Coral;
            }
            else if (x == left || x == right || y == up || y == down)
            {
                this.labelResult.Text = "Border";
                this.labelResult.BackColor = Color.LightBlue;
            }
            Visualize();
        }

        private void Visualize()
        {
            var x1 = this.numericUpDownx1.Value;
            var y1 = this.numericUpDowny1.Value;
            var x2 = this.numericUpDownx2.Value;
            var y2 = this.numericUpDowny2.Value;
            var x = this.numericUpDownx.Value;
            var y = this.numericUpDowny.Value;

            var minx = Min(x1, x2, x);
            var maxx = Max(x1, x2, x);
            var miny = Min(y1, y2, y);
            var maxy = Max(y1, y2, y);
            var diagramWidth = maxx - minx;
            var diagramHeight = maxy - miny;
            var ratio = 1.0m;
            var offset = 10;

            if (diagramWidth != 0 && diagramHeight != 0)
            {
                var ratiox = (pictureBox.Width - 2 * offset - 1) / diagramWidth;
                var ratioy = (pictureBox.Width - 2 * offset - 1) / diagramHeight;
                ratio = Math.Min(ratiox, ratioy);
            }

            var rectLeft = offset + (int)Math.Round((Math.Min(x1, x2) - minx) * ratio);
            var rectTop = offset + (int)Math.Round((Math.Min(y1, y2) - miny) * ratio);
            var rectWidth = (int)Math.Round(Math.Abs(x2 - x1) * ratio);
            var rectHeight = (int)Math.Round(Math.Abs(y2 - y1) * ratio);
            var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            var pointx = (int)Math.Round(offset + (x - minx) * ratio);
            var pointy = (int)Math.Round(offset + (y - miny) * ratio);
            var pointRect = new Rectangle(pointx - 2, pointy - 2, 5, 5);

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.Clear(Color.White);
                var pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rect);
                pen = new Pen(Color.DarkBlue, 5);
                g.DrawEllipse(pen, pointRect);
            }
        }

        private decimal Min(decimal val1, decimal val2, decimal val3)
        {
            return Math.Min(val1, Math.Min(val2, val3));
        }

        private decimal Max(decimal val1, decimal val2, decimal val3)
        {
            return Math.Max(val1, Math.Max(val2, val3));
        }

        private void numericUpDownx1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDowny1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownx2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDowny2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownx_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDowny_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
