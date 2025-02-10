namespace ATMWinForms.Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnTransfer = new Button();
            tbBalance = new TextBox();
            tbCardNumber = new TextBox();
            lblBalance = new Label();
            lblCardNumber = new Label();
            btnPut = new Button();
            btnExit = new Button();
            btnWithdraw = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(237, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(207, 42);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Main Menu";
            // 
            // btnTransfer
            // 
            btnTransfer.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnTransfer.Location = new Point(462, 208);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(166, 58);
            btnTransfer.TabIndex = 12;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // tbBalance
            // 
            tbBalance.Location = new Point(221, 133);
            tbBalance.Name = "tbBalance";
            tbBalance.ReadOnly = true;
            tbBalance.Size = new Size(295, 23);
            tbBalance.TabIndex = 11;
            // 
            // tbCardNumber
            // 
            tbCardNumber.Location = new Point(221, 76);
            tbCardNumber.Name = "tbCardNumber";
            tbCardNumber.ReadOnly = true;
            tbCardNumber.Size = new Size(295, 23);
            tbCardNumber.TabIndex = 10;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBalance.Location = new Point(125, 132);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(90, 24);
            lblBalance.TabIndex = 9;
            lblBalance.Text = "Balance:";
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCardNumber.Location = new Point(76, 75);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(139, 24);
            lblCardNumber.TabIndex = 8;
            lblCardNumber.Text = "Card Number:";
            // 
            // btnPut
            // 
            btnPut.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnPut.Location = new Point(12, 272);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(166, 58);
            btnPut.TabIndex = 13;
            btnPut.Text = "Deposit";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(462, 272);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 58);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnWithdraw.Location = new Point(12, 208);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(166, 58);
            btnWithdraw.TabIndex = 15;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(640, 342);
            Controls.Add(btnWithdraw);
            Controls.Add(btnExit);
            Controls.Add(btnPut);
            Controls.Add(btnTransfer);
            Controls.Add(tbBalance);
            Controls.Add(tbCardNumber);
            Controls.Add(lblBalance);
            Controls.Add(lblCardNumber);
            Controls.Add(lblWelcome);
            MaximumSize = new Size(656, 381);
            MinimumSize = new Size(656, 381);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblWelcome;
        private Button btnTransfer;
        private TextBox tbBalance;
        private TextBox tbCardNumber;
        private Label lblBalance;
        private Label lblCardNumber;
        private Button btnPut;
        private Button btnExit;
        private Button btnWithdraw;
    }
}