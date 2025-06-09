namespace WindowsFormsApp2
{
    partial class Login
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
            this.enter = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Label();
            this.logbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Hello = new System.Windows.Forms.Label();
            this.captchbox = new System.Windows.Forms.TextBox();
            this.captchpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.captchpic)).BeginInit();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(229, 290);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // registration
            // 
            this.registration.AutoSize = true;
            this.registration.Location = new System.Drawing.Point(66, 290);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(144, 16);
            this.registration.TabIndex = 1;
            this.registration.Text = "Зарегистрироваться";
            this.registration.Click += new System.EventHandler(this.label1_Click);
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(128, 128);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(158, 22);
            this.logbox.TabIndex = 2;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(128, 163);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(158, 22);
            this.passwordbox.TabIndex = 3;
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(76, 128);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(46, 16);
            this.Log.TabIndex = 4;
            this.Log.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(66, 163);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 16);
            this.Password.TabIndex = 5;
            this.Password.Text = "Пароль";
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Location = new System.Drawing.Point(149, 96);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(104, 16);
            this.Hello.TabIndex = 6;
            this.Hello.Text = "Здравствуйте!";
            // 
            // captchbox
            // 
            this.captchbox.Location = new System.Drawing.Point(128, 251);
            this.captchbox.Name = "captchbox";
            this.captchbox.Size = new System.Drawing.Size(158, 22);
            this.captchbox.TabIndex = 7;
            // 
            // captchpic
            // 
            this.captchpic.Location = new System.Drawing.Point(128, 195);
            this.captchpic.Name = "captchpic";
            this.captchpic.Size = new System.Drawing.Size(158, 50);
            this.captchpic.TabIndex = 8;
            this.captchpic.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 355);
            this.Controls.Add(this.captchpic);
            this.Controls.Add(this.captchbox);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.enter);
            this.Name = "Login";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.captchpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.TextBox captchbox;
        private System.Windows.Forms.PictureBox captchpic;
    }
}