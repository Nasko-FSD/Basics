namespace BGN_to_EUR_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }
        void Convert()
        {
            var amount = this.numericUpDownAmount.Value;
            var amountInEuro = amount / 1.95583m;
            this.labelResult.Text = amount + "BGN = " + Math.Round(amountInEuro, 2) + "EUR";
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void numericUpDownAmount_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
    }
}
