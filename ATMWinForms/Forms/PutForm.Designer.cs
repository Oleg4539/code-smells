namespace ATMWinForms.Forms
{
    partial class PutForm
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
            btn10 = new Button();
            tbAmount = new TextBox();
            lblAmount = new Label();
            lblPut = new Label();
            btn20 = new Button();
            btn100 = new Button();
            btn200 = new Button();
            btnBack = new Button();
            btn50 = new Button();
            btn500 = new Button();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // btn10
            // 
            btn10.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn10.Location = new Point(66, 115);
            btn10.Name = "btn10";
            btn10.Size = new Size(212, 41);
            btn10.TabIndex = 11;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(209, 71);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(256, 21);
            tbAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAmount.Location = new Point(114, 68);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(89, 24);
            lblAmount.TabIndex = 7;
            lblAmount.Text = "Amount:";
            // 
            // lblPut
            // 
            lblPut.AutoSize = true;
            lblPut.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPut.ForeColor = SystemColors.ButtonHighlight;
            lblPut.Location = new Point(260, 9);
            lblPut.Name = "lblPut";
            lblPut.Size = new Size(136, 42);
            lblPut.TabIndex = 6;
            lblPut.Text = "Deposit";
            // 
            // btn20
            // 
            btn20.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn20.Location = new Point(66, 175);
            btn20.Name = "btn20";
            btn20.Size = new Size(212, 41);
            btn20.TabIndex = 12;
            btn20.Text = "20";
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += btn20_Click;
            // 
            // btn100
            // 
            btn100.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn100.Location = new Point(363, 115);
            btn100.Name = "btn100";
            btn100.Size = new Size(212, 41);
            btn100.TabIndex = 13;
            btn100.Text = "100";
            btn100.UseVisualStyleBackColor = true;
            btn100.Click += btn100_Click;
            // 
            // btn200
            // 
            btn200.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn200.Location = new Point(363, 175);
            btn200.Name = "btn200";
            btn200.Size = new Size(212, 41);
            btn200.TabIndex = 14;
            btn200.Text = "200";
            btn200.UseVisualStyleBackColor = true;
            btn200.Click += btn200_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.Location = new Point(12, 283);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 47);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btn50
            // 
            btn50.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn50.Location = new Point(66, 236);
            btn50.Name = "btn50";
            btn50.Size = new Size(212, 41);
            btn50.TabIndex = 16;
            btn50.Text = "50";
            btn50.UseVisualStyleBackColor = true;
            btn50.Click += btn50_Click;
            // 
            // btn500
            // 
            btn500.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn500.Location = new Point(363, 236);
            btn500.Name = "btn500";
            btn500.Size = new Size(212, 41);
            btn500.TabIndex = 17;
            btn500.Text = "500";
            btn500.UseVisualStyleBackColor = true;
            btn500.Click += btn500_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEnter.Location = new Point(475, 283);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(153, 47);
            btnEnter.TabIndex = 19;
            btnEnter.Text = "Conirm";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // PutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(640, 342);
            Controls.Add(btnEnter);
            Controls.Add(btn500);
            Controls.Add(btn50);
            Controls.Add(btnBack);
            Controls.Add(btn200);
            Controls.Add(btn100);
            Controls.Add(btn20);
            Controls.Add(btn10);
            Controls.Add(tbAmount);
            Controls.Add(lblAmount);
            Controls.Add(lblPut);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MaximizeBox = false;
            MaximumSize = new Size(656, 381);
            MinimumSize = new Size(656, 381);
            Name = "PutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Put";
            Load += PutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn10;
        private TextBox tbAmount;
        private Label lblAmount;
        private Label lblPut;
        private Button btn20;
        private Button btn100;
        private Button btn200;
        private Button btnBack;
        private Button btn50;
        private Button btn500;
        private Button btnEnter;
    }
}