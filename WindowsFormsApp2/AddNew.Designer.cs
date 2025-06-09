namespace WindowsFormsApp2
{
    partial class AddNew
    {
        private const string V = "addnw";

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

        private System.Windows.Forms.Label GetV(System.Windows.Forms.Label v) => v;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(System.Windows.Forms.Label addnw)
        {
            this.Add = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Storage = new System.Windows.Forms.Label();
            this.Slot = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Deliver = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(216, 238);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(83, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(22, 238);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(19, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(73, 16);
            this.Name.TabIndex = 5;
            this.Name.Text = "Название";
            this.Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(19, 92);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(112, 16);
            this.Count.TabIndex = 6;
            this.Count.Text = "Количество(ед.)";
            this.Count.Click += new System.EventHandler(this.label3_Click);
            // 
            // Storage
            // 
            this.Storage.AutoSize = true;
            this.Storage.Location = new System.Drawing.Point(19, 120);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(47, 16);
            this.Storage.TabIndex = 7;
            this.Storage.Text = "Склад";
            this.Storage.Click += new System.EventHandler(this.label4_Click);
            // 
            // Slot
            // 
            this.Slot.AutoSize = true;
            this.Slot.Location = new System.Drawing.Point(19, 148);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(76, 16);
            this.Slot.TabIndex = 8;
            this.Slot.Text = "Ячейка(-и)";
            this.Slot.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(163, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Deliver
            // 
            this.Deliver.AutoSize = true;
            this.Deliver.Location = new System.Drawing.Point(19, 64);
            this.Deliver.Name = "Deliver";
            this.Deliver.Size = new System.Drawing.Size(79, 16);
            this.Deliver.TabIndex = 12;
            this.Deliver.Text = "Поставщик";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 312);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Deliver);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Add);
            this.Name = addnw;
            this.Text = "Добавить предмет";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Storage;
        private System.Windows.Forms.Label Slot;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Deliver;
        private System.Windows.Forms.TextBox textBox1;
    }
}