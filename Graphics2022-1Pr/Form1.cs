namespace Graphics2022_1Pr
{
    public partial class Form1 : Form
    {
        private Painter painter = new Painter(new Random().Next(-5,20));
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            painter.Paint(e.Graphics);
        }
    }
}