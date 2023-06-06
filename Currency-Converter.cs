using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }
        private void ConvertCurrency()
        {
            decimal number = this.numericUpDownAmount.Value;
            string currency = this.comboBoxCurrency.SelectedItem.ToString();

            decimal convertedAmount = number;
            if (currency == "EUR")
                convertedAmount = number / 1.95583m;
            else if (currency == "USD")
                convertedAmount = number / 180810m;
            else if (currency == "GBP")
                convertedAmount = number / 2.54990m;

            this.labelResult.Text = number + "BGN -> " + Math.Round(convertedAmount, 2) + " " + currency;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxCurrency.SelectedItem = "EUR";
        }
    }
}
