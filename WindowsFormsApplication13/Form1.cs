using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        int[] mas ={0,0,0,0};
        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                mas[2] = mas[2] - 10;
                g = pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.Black, 3f);
                Point[] points ={new Point(mas[0],mas[1]),new Point(mas[2],mas[3])};
                g.DrawLine(pen,points[0],points[1]);
                mas[0] = mas[2];
                mas[1] = mas[3];
                
            }
            else if (e.KeyCode == Keys.D)
            {
                mas[2] = mas[2] + 10;
                g = pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.Black, 3f);
                Point[] points = {new Point(mas[0],mas[1]),new Point(mas[2],mas[3])};
                g.DrawLine(pen, points[0], points[1]);
                mas[0] = mas[2];
                mas[1] = mas[3];
            }
            else if (e.KeyCode == Keys.W)
            {
                mas[3] = mas[3] - 10;
                g = pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.Black, 3f);
                Point[] points = {new Point(mas[0],mas[1]),new Point(mas[2],mas[3])};
                g.DrawLine(pen, points[0], points[1]);
                mas[0] = mas[2];
                mas[1] = mas[3];
            }
            else if (e.KeyCode == Keys.S)
            {
                mas[3]= mas[3] + 10;
                g = pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.Black, 3f);
                Point[] points = { new Point(mas[0],mas[1]),new Point(mas[2],mas[3])};
                g.DrawLine(pen, points[0], points[1]);
                mas[0] = mas[2];
                mas[1] = mas[3];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
