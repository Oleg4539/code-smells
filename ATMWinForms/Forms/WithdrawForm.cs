using ATM.ClassLibrary.CustomEventArgs;

namespace ATMWinForms.Forms
{
    public partial class WithdrawForm : Form
    {
        private int sum = 0;
        private int value = 0;
        private MainForm mainForm;
        public WithdrawForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetHandler();
        }
        private void SetHandler()
        {
            mainForm.Session.SetWithdrawHandler(withdrawHandler!);
        }

        private void withdrawHandler(object sender, WithdrawEventArgs e)
        {
            if (e.AccountBalanceLack)
            {
                MessageBox.Show("There is lack of money on your balance.", default,
               default, MessageBoxIcon.Error);
                return;
            }
            else if (e.ATMCashLack)
            {
                DialogResult result = MessageBox.Show("Sorry. There is lack of cash in ATM. " +
                    "Do you want to withdraw a smaller sum?", default,
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tbAmount.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    CloseForm();
                }
                return;
            }
            CloseForm();
        }

        private void CloseForm()
        {
            mainForm.Session.RemoveWithdrawHandler(withdrawHandler!);
            mainForm.OpenMenuForm();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(tbAmount.Text, out amount))
            {
                MessageBox.Show("Enter an integer to the sum field.", default, default,
               MessageBoxIcon.Error);
                return;
            }
            mainForm.Session.Withdraw(amount);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn10.Text, out value))
            {
                sum += value;
            }
            tbAmount.Text = sum.ToString();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn20.Text, out value))
            {
                sum += value;
            }
            tbAmount.Text = sum.ToString();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn50.Text, out value))
            {
                sum += value;
            }
            tbAmount.Text = sum.ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn100.Text, out value))
            {
                sum += value;
            }
            tbAmount.Text = sum.ToString();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn200.Text, out value))
            {
                sum += value;
            }
            tbAmount.Text = sum.ToString();
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn500.Text, out value))
            {
                sum += value;
            }
            tbAmount.Text = sum.ToString();
        }
    }
}
