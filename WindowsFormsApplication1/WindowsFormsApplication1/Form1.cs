using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Graphics g = null;
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(Handle);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Brush b = new SolidBrush(Color.Black);

            Pen pen = new Pen(b, 1);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(100, 100);
            Point p3 = new Point(50, 100);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);

        }
    }
}
