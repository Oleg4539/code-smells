namespace ATMWinForms.Forms
{
    partial class TransferForm
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
            tbRecipient = new TextBox();
            lblRecipient = new Label();
            lblTransfer = new Label();
            tbAmount = new TextBox();
            lblAmount = new Label();
            btnEnter = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // tbRecipient
            // 
            tbRecipient.Location = new Point(225, 102);
            tbRecipient.Name = "tbRecipient";
            tbRecipient.Size = new Size(256, 21);
            tbRecipient.TabIndex = 16;
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblRecipient.Location = new Point(80, 160);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(139, 24);
            lblRecipient.TabIndex = 15;
            lblRecipient.Text = "Card Number:";
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTransfer.ForeColor = SystemColors.ButtonHighlight;
            lblTransfer.Location = new Point(241, 9);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new Size(155, 42);
            lblTransfer.TabIndex = 14;
            lblTransfer.Text = "Transfer";
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(225, 164);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(256, 21);
            tbAmount.TabIndex = 18;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAmount.Location = new Point(130, 98);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(89, 24);
            lblAmount.TabIndex = 17;
            lblAmount.Text = "Amount:";
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEnter.Location = new Point(475, 283);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(153, 47);
            btnEnter.TabIndex = 21;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.Location = new Point(12, 283);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 47);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(640, 342);
            Controls.Add(btnEnter);
            Controls.Add(btnBack);
            Controls.Add(tbAmount);
            Controls.Add(lblAmount);
            Controls.Add(tbRecipient);
            Controls.Add(lblRecipient);
            Controls.Add(lblTransfer);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MaximizeBox = false;
            MaximumSize = new Size(656, 381);
            MinimumSize = new Size(656, 381);
            Name = "TransferForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbRecipient;
        private Label lblRecipient;
        private Label lblTransfer;
        private TextBox tbAmount;
        private Label lblAmount;
        private Button btnEnter;
        private Button btnBack;
    }
}