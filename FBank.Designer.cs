namespace UseBank
{
    partial class FBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBank));
            btnReplenishMoney=new Button();
            btnTransferMoney=new Button();
            btnWithdrawMoney=new Button();
            lblBalance=new Label();
            textBoxSum=new TextBox();
            lblUserLogin=new Label();
            lblMoneyBelow=new Label();
            btnExitAccount=new Button();
            lblMoneyBelowTransfer=new Label();
            textBoxLoginTransfer=new TextBox();
            btnHistoryOperations=new Button();
            SuspendLayout();
            // 
            // btnReplenishMoney
            // 
            btnReplenishMoney.BackColor=Color.Indigo;
            btnReplenishMoney.BackgroundImageLayout=ImageLayout.None;
            btnReplenishMoney.FlatStyle=FlatStyle.Flat;
            btnReplenishMoney.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnReplenishMoney.ForeColor=Color.MediumPurple;
            btnReplenishMoney.Location=new Point(12, 262);
            btnReplenishMoney.Name="btnReplenishMoney";
            btnReplenishMoney.Size=new Size(167, 37);
            btnReplenishMoney.TabIndex=5;
            btnReplenishMoney.Text="Внести";
            btnReplenishMoney.UseVisualStyleBackColor=false;
            btnReplenishMoney.Click+=btnReplenishMoney_Click;
            // 
            // btnTransferMoney
            // 
            btnTransferMoney.BackColor=Color.Indigo;
            btnTransferMoney.BackgroundImageLayout=ImageLayout.None;
            btnTransferMoney.FlatStyle=FlatStyle.Flat;
            btnTransferMoney.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransferMoney.ForeColor=Color.MediumPurple;
            btnTransferMoney.Location=new Point(348, 262);
            btnTransferMoney.Name="btnTransferMoney";
            btnTransferMoney.Size=new Size(167, 37);
            btnTransferMoney.TabIndex=6;
            btnTransferMoney.Text="Перевести";
            btnTransferMoney.UseVisualStyleBackColor=false;
            btnTransferMoney.Click+=btnTransferMoney_Click;
            // 
            // btnWithdrawMoney
            // 
            btnWithdrawMoney.BackColor=Color.Indigo;
            btnWithdrawMoney.BackgroundImageLayout=ImageLayout.None;
            btnWithdrawMoney.FlatStyle=FlatStyle.Flat;
            btnWithdrawMoney.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnWithdrawMoney.ForeColor=Color.MediumPurple;
            btnWithdrawMoney.Location=new Point(180, 262);
            btnWithdrawMoney.Name="btnWithdrawMoney";
            btnWithdrawMoney.Size=new Size(167, 37);
            btnWithdrawMoney.TabIndex=6;
            btnWithdrawMoney.Text="Снять";
            btnWithdrawMoney.UseVisualStyleBackColor=false;
            btnWithdrawMoney.Click+=btnWithdrawMoney_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize=true;
            lblBalance.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.ForeColor=Color.Indigo;
            lblBalance.Location=new Point(12, 9);
            lblBalance.Name="lblBalance";
            lblBalance.Size=new Size(154, 25);
            lblBalance.TabIndex=8;
            lblBalance.Text="Баланс: 0 монет";
            // 
            // textBoxSum
            // 
            textBoxSum.BackColor=Color.Indigo;
            textBoxSum.BorderStyle=BorderStyle.None;
            textBoxSum.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSum.ForeColor=Color.MediumPurple;
            textBoxSum.Location=new Point(12, 143);
            textBoxSum.Name="textBoxSum";
            textBoxSum.Size=new Size(503, 25);
            textBoxSum.TabIndex=7;
            textBoxSum.KeyPress+=textBoxSum_KeyPress;
            // 
            // lblUserLogin
            // 
            lblUserLogin.AutoSize=true;
            lblUserLogin.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserLogin.ForeColor=Color.Indigo;
            lblUserLogin.Location=new Point(12, 34);
            lblUserLogin.Name="lblUserLogin";
            lblUserLogin.Size=new Size(195, 25);
            lblUserLogin.TabIndex=9;
            lblUserLogin.Text="Пользователь: None";
            // 
            // lblMoneyBelow
            // 
            lblMoneyBelow.AutoSize=true;
            lblMoneyBelow.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoneyBelow.ForeColor=Color.Indigo;
            lblMoneyBelow.Location=new Point(12, 115);
            lblMoneyBelow.Name="lblMoneyBelow";
            lblMoneyBelow.Size=new Size(303, 25);
            lblMoneyBelow.TabIndex=10;
            lblMoneyBelow.Text="Введите количество монет ниже";
            // 
            // btnExitAccount
            // 
            btnExitAccount.BackColor=Color.Indigo;
            btnExitAccount.BackgroundImageLayout=ImageLayout.None;
            btnExitAccount.FlatStyle=FlatStyle.Flat;
            btnExitAccount.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitAccount.ForeColor=Color.MediumPurple;
            btnExitAccount.Location=new Point(12, 62);
            btnExitAccount.Name="btnExitAccount";
            btnExitAccount.Size=new Size(154, 29);
            btnExitAccount.TabIndex=11;
            btnExitAccount.Text="Выйти из аккаунта";
            btnExitAccount.UseVisualStyleBackColor=false;
            btnExitAccount.Click+=btnExitAccount_Click;
            // 
            // lblMoneyBelowTransfer
            // 
            lblMoneyBelowTransfer.AutoSize=true;
            lblMoneyBelowTransfer.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoneyBelowTransfer.ForeColor=Color.Indigo;
            lblMoneyBelowTransfer.Location=new Point(12, 171);
            lblMoneyBelowTransfer.Name="lblMoneyBelowTransfer";
            lblMoneyBelowTransfer.Size=new Size(490, 25);
            lblMoneyBelowTransfer.TabIndex=13;
            lblMoneyBelowTransfer.Text="Введите логин получателя (только когда переводите)";
            // 
            // textBoxLoginTransfer
            // 
            textBoxLoginTransfer.BackColor=Color.Indigo;
            textBoxLoginTransfer.BorderStyle=BorderStyle.None;
            textBoxLoginTransfer.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLoginTransfer.ForeColor=Color.MediumPurple;
            textBoxLoginTransfer.Location=new Point(12, 199);
            textBoxLoginTransfer.Name="textBoxLoginTransfer";
            textBoxLoginTransfer.Size=new Size(503, 25);
            textBoxLoginTransfer.TabIndex=12;
            // 
            // btnHistoryOperations
            // 
            btnHistoryOperations.BackColor=Color.Indigo;
            btnHistoryOperations.BackgroundImageLayout=ImageLayout.None;
            btnHistoryOperations.FlatStyle=FlatStyle.Flat;
            btnHistoryOperations.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistoryOperations.ForeColor=Color.MediumPurple;
            btnHistoryOperations.Location=new Point(93, 300);
            btnHistoryOperations.Name="btnHistoryOperations";
            btnHistoryOperations.Size=new Size(335, 37);
            btnHistoryOperations.TabIndex=14;
            btnHistoryOperations.Text="История операций";
            btnHistoryOperations.UseVisualStyleBackColor=false;
            btnHistoryOperations.Click+=btnHistoryOperations_Click;
            // 
            // FBank
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.MediumPurple;
            ClientSize=new Size(532, 361);
            Controls.Add(btnHistoryOperations);
            Controls.Add(lblMoneyBelowTransfer);
            Controls.Add(textBoxLoginTransfer);
            Controls.Add(btnExitAccount);
            Controls.Add(lblMoneyBelow);
            Controls.Add(lblUserLogin);
            Controls.Add(lblBalance);
            Controls.Add(textBoxSum);
            Controls.Add(btnWithdrawMoney);
            Controls.Add(btnTransferMoney);
            Controls.Add(btnReplenishMoney);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            MaximumSize=new Size(548, 400);
            MinimumSize=new Size(548, 400);
            Name="FBank";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Банк";
            Load+=FBank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReplenishMoney;
        private Button btnTransferMoney;
        private Button btnWithdrawMoney;
        private Label lblBalance;
        private TextBox textBoxSum;
        private Label lblUserLogin;
        private Label lblMoneyBelow;
        private Button btnExitAccount;
        private Label lblMoneyBelowTransfer;
        private TextBox textBoxLoginTransfer;
        private Button btnHistoryOperations;
    }
}