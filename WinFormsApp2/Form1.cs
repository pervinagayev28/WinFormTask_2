namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            var width = this.Width;
            var height = this.Height - 10;
            Random random = new Random();
            button1.Location = new Point(random.Next(0, this.Width - button1.Width), random.Next(0, this.Height - button1.Height)); 
        }
    }
}