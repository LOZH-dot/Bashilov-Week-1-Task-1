namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value % 2 == 0)
            {
                ResultLabel.ForeColor = Color.Green;
                ResultLabel.Text = "Число четное";
            }
            else
            {
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = "Число нечетное";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (numericUpDown1.Value % 2 == 0)
            {
                ResultLabel.ForeColor = Color.Green;
                ResultLabel.Text = "Число четное";
            }
            else
            {
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = "Число нечетное";
            }
        }
    }
}