using ATM.ClassLibrary.CustomEventArgs;

namespace ATMWinForms.Forms
{
    public partial class AuthorizeForm : Form
    {
        private MainForm mainForm;

        public AuthorizeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetHandler();
        }

        private void SetHandler()
        {
            mainForm.Session.SetAuthorizeHandler(authorizeHandler!);
        }

        public void authorizeHandler(object sender, AuthorizeEventArgs e)
        {
            if (e.Success)
                CloseForm();
            else
            {
                MessageBox.Show("Incorrect password.", default, default,
                    MessageBoxIcon.Error);
                tbPassword.Text = "";
            }
        }

        public void CloseForm()
        {
            mainForm.Session.RemoveAuthorizeHandler(authorizeHandler!);
            mainForm.OpenMenuForm();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string cardNumber = tbCardNumber.Text.Trim();
            string password = tbPassword.Text.Trim();
            bool accountExists = mainForm.Session.Authorize(cardNumber, password);
            if (!accountExists)
            {
                tbCardNumber.Text = "";
                tbPassword.Text = "";
                MessageBox.Show("Enter a valid card number.", default, default,
                    MessageBoxIcon.Error);
            }
        }
    }
}
