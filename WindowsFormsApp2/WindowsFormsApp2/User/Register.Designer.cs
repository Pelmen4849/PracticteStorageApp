namespace WindowsFormsApp2
{
    partial class Register
    {
        private const string V = "Register";

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
        private void InitializeComponent(System.Windows.Forms.Label v)
        {
            this.Fam = new System.Windows.Forms.Label();
            this.Fambox = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Telephonebox = new System.Windows.Forms.TextBox();
            this.Surnamebox = new System.Windows.Forms.TextBox();
            this.Loginbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fam
            // 
            this.Fam.AutoSize = true;
            this.Fam.Location = new System.Drawing.Point(104, 18);
            this.Fam.Name = "Fam";
            this.Fam.Size = new System.Drawing.Size(66, 16);
            this.Fam.TabIndex = 0;
            this.Fam.Text = "Фамилия";
            // 
            // Fambox
            // 
            this.Fambox.Location = new System.Drawing.Point(180, 12);
            this.Fambox.Name = "Fambox";
            this.Fambox.Size = new System.Drawing.Size(100, 22);
            this.Fambox.TabIndex = 1;
            this.Fambox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(104, 75);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(70, 16);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Отчество";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(120, 47);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(33, 16);
            this.Name.TabIndex = 3;
            this.Name.Text = "Имя";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(55, 103);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(119, 16);
            this.Telephone.TabIndex = 4;
            this.Telephone.Text = "Номер телефона";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(124, 131);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(46, 16);
            this.Login.TabIndex = 5;
            this.Login.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(118, 159);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 16);
            this.Password.TabIndex = 6;
            this.Password.Text = "Пароль";
            this.Password.Click += new System.EventHandler(this.label6_Click);
            // 
            // Telephonebox
            // 
            this.Telephonebox.Location = new System.Drawing.Point(180, 97);
            this.Telephonebox.Name = "Telephonebox";
            this.Telephonebox.Size = new System.Drawing.Size(100, 22);
            this.Telephonebox.TabIndex = 7;
            // 
            // Surnamebox
            // 
            this.Surnamebox.Location = new System.Drawing.Point(180, 69);
            this.Surnamebox.Name = "Surnamebox";
            this.Surnamebox.Size = new System.Drawing.Size(100, 22);
            this.Surnamebox.TabIndex = 8;
            // 
            // Loginbox
            // 
            this.Loginbox.Location = new System.Drawing.Point(180, 125);
            this.Loginbox.Name = "Loginbox";
            this.Loginbox.Size = new System.Drawing.Size(100, 22);
            this.Loginbox.TabIndex = 9;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(180, 41);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 22);
            this.namebox.TabIndex = 10;
            this.namebox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Passwordbox
            // 
            this.Passwordbox.Location = new System.Drawing.Point(180, 153);
            this.Passwordbox.Name = "Passwordbox";
            this.Passwordbox.Size = new System.Drawing.Size(100, 22);
            this.Passwordbox.TabIndex = 11;
            // 
            // Registerbutton
            // 
            this.Registerbutton.Location = new System.Drawing.Point(169, 231);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(159, 36);
            this.Registerbutton.TabIndex = 12;
            this.Registerbutton.Text = "Зарегистрироваться";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(77, 231);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 36);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 308);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.Passwordbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.Loginbox);
            this.Controls.Add(this.Surnamebox);
            this.Controls.Add(this.Telephonebox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Fambox);
            this.Controls.Add(this.Fam);
            this.Name = v;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fam;
        private System.Windows.Forms.TextBox Fambox;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Telephonebox;
        private System.Windows.Forms.TextBox Surnamebox;
        private System.Windows.Forms.TextBox Loginbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button Exit;
    }
}