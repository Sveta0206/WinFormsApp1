namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Brush brush = Brushes.White;
            Graphics gr = this.CreateGraphics();
            //gr.FillPie(brush, 0, 20, 20, 20, 0, 270);
            gr.FillPie(brush, 0, 0, 100, 100, -90, 90);
            gr.Dispose();
        }
    }
}