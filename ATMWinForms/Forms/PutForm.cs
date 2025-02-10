using ATM.ClassLibrary.CustomEventArgs;

namespace ATMWinForms.Forms
{
    public partial class PutForm : Form
    {
        private MainForm mainForm;
        private int sum = 0;
        private int value = 0;
        public PutForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetHandler();
        }

        private void SetHandler()
        {
            mainForm.Session.SetPutHandler(putHandler!);
        }

        private void putHandler(object sender, AccountEventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            mainForm.Session.RemovePutHandler(putHandler!);
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
            mainForm.Session.Put(amount);
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
                tbAmount.Text = sum.ToString();
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn20.Text, out value))
            {
                sum += value;
                tbAmount.Text = sum.ToString();
            }
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn50.Text, out value))
            {
                sum += value;
                tbAmount.Text = sum.ToString();
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn100.Text, out value))
            {
                sum += value;
                tbAmount.Text = sum.ToString();
            }
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn200.Text, out value))
            {
                sum += value;
                tbAmount.Text = sum.ToString();
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(btn500.Text, out value))
            {
                sum += value;
                tbAmount.Text = sum.ToString();
            }
        }

        private void PutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
