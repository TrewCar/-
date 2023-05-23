using System.Drawing;
using System.Windows.Forms;

namespace Кривая_Коха
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Brushes.Black, 1);

            koch = new KochСurve(
                new Point(50, pictureBox1.Height - 50),
                new Point(pictureBox1.Width - 50, pictureBox1.Height - 50));
            Set(0);
        }
        KochСurve koch;
        Graphics g;
        Pen pen;
        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            label1.Text = "N = " + trackBar1.Value;
            Set(trackBar1.Value);
        }
        private void Set(int n)
        {      
            g.FillRectangle(Brushes.White, 0,0,pictureBox1.Width,pictureBox1.Height);

            koch.SetN(n);
            koch.Draw(g, pen);
            pictureBox1.Invalidate();
        }
    }
}
