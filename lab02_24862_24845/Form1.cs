using System;
using System.Windows.Forms;

namespace lab02_24862_24845
{
    public partial class Form1 : Form
    {
        private readonly AlcoholCalculator _calculator;

        public Form1()
        {
            InitializeComponent();
            _calculator = new AlcoholCalculator();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            // 1. Walidacja pojemności naczynia (txtVolume)
            if (!double.TryParse(txtVolume.Text, out double vesselVolume) || vesselVolume <= 0)
            {
                MessageBox.Show("Wprowadź poprawną pojemność naczynia (liczba dodatnia).",
                                "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVolume.Focus();
                return;
            }

            // 2. Walidacja zawartości procentowej (txtProcent)
            if (!double.TryParse(txtProcent.Text, out double percentage) || percentage < 0 || percentage > 100)
            {
                MessageBox.Show("Wprowadź poprawną zawartość procentową (od 0 do 100%).",
                                "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProcent.Focus();
                return;
            }

            // 3. Walidacja ilości sztuk (txtQuantity)
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Wprowadź poprawną ilość sztuk (liczba całkowita > 0).",
                                "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // 4. Obliczenia przy użyciu klasy logiki
            double totalVolume = _calculator.CalculateTotalVolume(vesselVolume, quantity);
            double pureAlcohol = _calculator.CalculatePureAlcohol(vesselVolume, percentage, quantity);

            // 5. Wyświetlenie wyników w polach wyjściowych
            txtVolumeDrink.Text = $"{totalVolume:F2} ml";
            txtVolumeSpirt.Text = $"{pureAlcohol:F2} ml";
        }
    }
}