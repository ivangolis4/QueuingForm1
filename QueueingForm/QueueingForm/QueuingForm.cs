namespace QueueingForm
{
    public partial class queuingForm : Form
    {
        private CashierClass cashier;
        public queuingForm(CashierClass cashier)
        {
            InitializeComponent();
            this.cashier = cashier;

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.cashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }
    }
}
