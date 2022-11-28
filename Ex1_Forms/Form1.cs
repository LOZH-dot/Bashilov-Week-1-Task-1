namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateAreaButton_Click(object sender, EventArgs e)
        {
            double p = (double)TrianglePerimeterNumeric.Value;

            double a = p / 3;

            MessageBox.Show($"Площадь равностороннего треугольника с периметром равным {p} (округлено до двух знаков после запятой): {Math.Round((a * a * Math.Sqrt(3)) / 4, 2)}",
                "Результат",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}