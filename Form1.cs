namespace CW_Forms_GDI
{
    public partial class Form1 : Form
    {
        Pen pen;
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 1);
            gr = panel1.CreateGraphics();
            textBoxX1.Text = $"{0}";
            textBoxX2.Text = $"{0}";
            textBoxY1.Text = $"{0}";
            textBoxY2.Text = $"{0}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            pen.Color = colorDialog1.Color;
            pen.Width = trackBar1.Value;
            int.TryParse(textBoxX1.Text, out int x1);
            int.TryParse(textBoxY1.Text, out int y1);
            int.TryParse(textBoxX2.Text, out int x2);
            int.TryParse(textBoxY2.Text, out int y2);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            gr.DrawLine(pen, p1, p2);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelCurrentPenWidth.Text = $"{trackBar1.Value}";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
        }
    }
}