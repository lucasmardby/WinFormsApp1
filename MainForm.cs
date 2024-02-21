namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private CurrencyExchange converter = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        { 
            lblResult.Text = string.Empty;
            lblResult.ForeColor = Color.DarkGreen;
            this.Text = "Currency Converter";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ok = ReadInput();

            if (ok)
            {
                double convertedAmount = converter.CalculateNewAmount();
                lblResult.Text = convertedAmount.ToString("0.00");
            }
        }
        private bool ReadInput()
        {
            bool amountOk = ReadAmount();
            bool rateOk = ReadExchangeRate();

            return amountOk && rateOk;
        }
        private bool ReadAmount()
        {
            bool ok;
            string strAmount = txtAmount.Text;
            strAmount = strAmount.Trim();
            ok = double.TryParse(strAmount, out double amount);

            if ( ok )
            {
                converter.SetAmountToExchange(amount);
            }
            else
            {
                MessageBox.Show("Invalid amount!", "Error!");
            }
            return ok;
        }
        private bool ReadExchangeRate()
        {
            bool ok;
            string strRate = txtRate.Text;
            strRate = strRate.Trim();
            ok = double.TryParse(strRate, out double amount);

            if (ok)
            {
                converter.SetExchangeRate(amount);
            }
            else
            {
                MessageBox.Show("Invalid exchange rate!", "Error!");
            }
            return ok;
        }
    }
}
