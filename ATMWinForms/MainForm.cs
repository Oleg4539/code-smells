using ATM.ClassLibrary;
using ATM.ClassLibrary.Classes;
using ATMWinForms.Forms;

namespace ATMWinForms
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        public Session Session { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            SetSession();
            OpenChildForm(new AuthorizeForm(this));
        }
        private void SetSession()
        {
            string customersDataPath = @"../../../../customers.json";
            var atms = new List<AutomatedTellerMachine>
        { new AutomatedTellerMachine("12", "Korolyova 24b", 1000000) };
            var bank = new Bank("Privat23", atms, customersDataPath);
            int atmId = 0;
            Session = new Session(bank, atmId);
        }
        public void OpenAuthorizeForm()
        {
            OpenChildForm(new AuthorizeForm(this));
        }
        public void OpenMenuForm()
        {
            OpenChildForm(new MenuForm(this));
        }
        public void OpenPutForm()
        {
            OpenChildForm(new PutForm(this));
        }
        public void OpenWithdrawForm()
        {
            OpenChildForm(new WithdrawForm(this));
        }
        public void OpenTransferForm()
        {
            OpenChildForm(new TransferForm(this));
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            activeForm = childForm;
        }
    }
}
