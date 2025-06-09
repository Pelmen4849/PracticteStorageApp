namespace WindowsFormsApp2
{
    partial class AddMain
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
            this.Exit = new System.Windows.Forms.Button();
            this.AddExciste = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(144, 249);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddExciste
            // 
            this.AddExciste.Location = new System.Drawing.Point(97, 151);
            this.AddExciste.Name = "AddExciste";
            this.AddExciste.Size = new System.Drawing.Size(163, 61);
            this.AddExciste.TabIndex = 4;
            this.AddExciste.Text = "Добавить к существующему товару";
            this.AddExciste.UseVisualStyleBackColor = true;
            this.AddExciste.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(97, 68);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(163, 61);
            this.AddNew.TabIndex = 3;
            this.AddNew.Text = "Добавить новые товары";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 321);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddExciste);
            this.Controls.Add(this.AddNew);
            this.Name = "AddMain";
            this.Text = "AddMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddExciste;
        private System.Windows.Forms.Button AddNew;
    }
}