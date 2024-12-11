namespace MarvelFilmek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            GridView gw = new GridView();
            gw.Dock = DockStyle.Fill;
            panel1.Controls.Add(gw);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            ListBox lb = new();
            lb.Dock = DockStyle.Fill;
            panel1.Controls.Add(lb);
        }
    }
}