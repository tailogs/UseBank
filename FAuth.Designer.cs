namespace UseBank
{
    partial class FAuth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLogin=new TextBox();
            lblLogin=new Label();
            lblPassword=new Label();
            textBoxPassword=new TextBox();
            btnAuth=new Button();
            btnReg=new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor=Color.Indigo;
            textBoxLogin.BorderStyle=BorderStyle.None;
            textBoxLogin.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.ForeColor=Color.MediumPurple;
            textBoxLogin.Location=new Point(12, 37);
            textBoxLogin.Name="textBoxLogin";
            textBoxLogin.Size=new Size(320, 25);
            textBoxLogin.TabIndex=0;
            textBoxLogin.TextAlign=HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize=true;
            lblLogin.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor=Color.Indigo;
            lblLogin.Location=new Point(142, 9);
            lblLogin.Name="lblLogin";
            lblLogin.Size=new Size(65, 25);
            lblLogin.TabIndex=1;
            lblLogin.Text="Логин";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize=true;
            lblPassword.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor=Color.Indigo;
            lblPassword.Location=new Point(142, 68);
            lblPassword.Name="lblPassword";
            lblPassword.Size=new Size(78, 25);
            lblPassword.TabIndex=3;
            lblPassword.Text="Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor=Color.Indigo;
            textBoxPassword.BorderStyle=BorderStyle.None;
            textBoxPassword.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor=Color.MediumPurple;
            textBoxPassword.Location=new Point(12, 96);
            textBoxPassword.Name="textBoxPassword";
            textBoxPassword.Size=new Size(320, 25);
            textBoxPassword.TabIndex=2;
            textBoxPassword.TextAlign=HorizontalAlignment.Center;
            // 
            // btnAuth
            // 
            btnAuth.BackColor=Color.Indigo;
            btnAuth.BackgroundImageLayout=ImageLayout.None;
            btnAuth.FlatStyle=FlatStyle.Flat;
            btnAuth.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuth.ForeColor=Color.MediumPurple;
            btnAuth.Location=new Point(165, 146);
            btnAuth.Name="btnAuth";
            btnAuth.Size=new Size(167, 37);
            btnAuth.TabIndex=4;
            btnAuth.Text="Авторизация";
            btnAuth.UseVisualStyleBackColor=false;
            btnAuth.Click+=btnAuth_Click;
            // 
            // btnReg
            // 
            btnReg.BackColor=Color.Indigo;
            btnReg.BackgroundImageLayout=ImageLayout.None;
            btnReg.FlatStyle=FlatStyle.Flat;
            btnReg.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnReg.ForeColor=Color.MediumPurple;
            btnReg.Location=new Point(12, 146);
            btnReg.Name="btnReg";
            btnReg.Size=new Size(147, 37);
            btnReg.TabIndex=5;
            btnReg.Text="Регистрация";
            btnReg.UseVisualStyleBackColor=false;
            btnReg.Click+=btnReg_Click;
            // 
            // FAuth
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.MediumPurple;
            ClientSize=new Size(344, 198);
            Controls.Add(btnReg);
            Controls.Add(btnAuth);
            Controls.Add(lblPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(lblLogin);
            Controls.Add(textBoxLogin);
            FormBorderStyle=FormBorderStyle.FixedToolWindow;
            MaximumSize=new Size(360, 237);
            MinimumSize=new Size(360, 237);
            Name="FAuth";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox textBoxPassword;
        private Button btnAuth;
        private Button btnReg;
    }
}