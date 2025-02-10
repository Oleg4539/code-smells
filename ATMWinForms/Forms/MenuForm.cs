using ATM.ClassLibrary.CustomEventArgs;

namespace ATMWinForms.Forms
{
    public partial class MenuForm : Form
    {
        private MainForm mainForm;
        public MenuForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetHandler();
        }

        private void SetHandler()
        {
            mainForm.Session.SetCheckBalanceHandler(checkBalanceHandler!);
        }

        public void CloseForm()
        {
            mainForm.Session.RemoveCheckBalanceHandler(checkBalanceHandler!);
            mainForm.OpenAuthorizeForm();
        }

        public void checkBalanceHandler(object sender, CheckBalanceEventArgs e)
        {
            tbBalance.Text = e.Balance.ToString();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            tbCardNumber.Text = $"{mainForm.Session.Account.CardNumber}";
            mainForm.Session.CheckBalance();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            mainForm.OpenTransferForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainForm.OpenAuthorizeForm();
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            mainForm.OpenPutForm();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            mainForm.OpenWithdrawForm();
        }
    }
}
