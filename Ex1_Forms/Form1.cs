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

            MessageBox.Show($"������� ��������������� ������������ � ���������� ������ {p} (��������� �� ���� ������ ����� �������): {Math.Round((a * a * Math.Sqrt(3)) / 4, 2)}",
                "���������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}