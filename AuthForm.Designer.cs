namespace goldfish
{
    partial class AuthForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            loginInput = new TextBox();
            passInput = new TextBox();
            authBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // loginInput
            // 
            loginInput.BackColor = Color.White;
            loginInput.Font = new Font("Times New Roman", 10.2F);
            loginInput.Location = new Point(46, 198);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(247, 27);
            loginInput.TabIndex = 0;
            // 
            // passInput
            // 
            passInput.BackColor = Color.White;
            passInput.Font = new Font("Times New Roman", 10.2F);
            passInput.Location = new Point(46, 248);
            passInput.Name = "passInput";
            passInput.PasswordChar = '●';
            passInput.Size = new Size(247, 27);
            passInput.TabIndex = 1;
            // 
            // authBtn
            // 
            authBtn.BackColor = Color.FromArgb(2, 46, 77);
            authBtn.Font = new Font("Times New Roman", 10.2F);
            authBtn.ForeColor = Color.White;
            authBtn.Location = new Point(117, 281);
            authBtn.Name = "authBtn";
            authBtn.Size = new Size(102, 35);
            authBtn.TabIndex = 2;
            authBtn.Text = "Войти";
            authBtn.UseVisualStyleBackColor = false;
            authBtn.Click += AuthBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(144, 176);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(144, 226);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(94, 25);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(169, 113);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 5;
            pictureBoxLogo.TabStop = false;
            // 
            // AuthForm
            // 
            AcceptButton = authBtn;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(363, 403);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(authBtn);
            Controls.Add(passInput);
            Controls.Add(loginInput);
            Font = new Font("Times New Roman", 10.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
