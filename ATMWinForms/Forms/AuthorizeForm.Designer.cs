namespace ATMWinForms.Forms
{
    partial class AuthorizeForm
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
            lblAuthorization = new Label();
            lblCardNumber = new Label();
            lblPassword = new Label();
            tbCardNumber = new TextBox();
            tbPassword = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblAuthorization
            // 
            lblAuthorization.AutoSize = true;
            lblAuthorization.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAuthorization.ForeColor = SystemColors.Control;
            lblAuthorization.Location = new Point(204, 9);
            lblAuthorization.Name = "lblAuthorization";
            lblAuthorization.Size = new Size(237, 42);
            lblAuthorization.TabIndex = 0;
            lblAuthorization.Text = "Authorization";
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCardNumber.Location = new Point(60, 89);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(139, 24);
            lblCardNumber.TabIndex = 1;
            lblCardNumber.Text = "Card Number:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(146, 153);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(53, 24);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "PIN:";
            // 
            // tbCardNumber
            // 
            tbCardNumber.Location = new Point(205, 90);
            tbCardNumber.Name = "tbCardNumber";
            tbCardNumber.Size = new Size(295, 23);
            tbCardNumber.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(205, 154);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(295, 23);
            tbPassword.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnter.BackColor = SystemColors.ActiveCaption;
            btnEnter.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEnter.ForeColor = SystemColors.ButtonHighlight;
            btnEnter.Location = new Point(146, 200);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(354, 73);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Login";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // AuthorizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(640, 342);
            Controls.Add(btnEnter);
            Controls.Add(tbPassword);
            Controls.Add(tbCardNumber);
            Controls.Add(lblPassword);
            Controls.Add(lblCardNumber);
            Controls.Add(lblAuthorization);
            MaximizeBox = false;
            MaximumSize = new Size(656, 381);
            MinimumSize = new Size(656, 381);
            Name = "AuthorizeForm";
            Text = "AuthorizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthorization;
        private Label lblCardNumber;
        private Label lblPassword;
        private TextBox tbCardNumber;
        private TextBox tbPassword;
        private Button btnEnter;
    }
}