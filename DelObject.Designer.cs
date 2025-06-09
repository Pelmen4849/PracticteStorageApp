namespace WindowsFormsApp2
{
    partial class DelObject
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
        private void InitializeComponent(System.Windows.Forms.Label delobj)
        {
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.countbox = new System.Windows.Forms.TextBox();
            this.storagebox = new System.Windows.Forms.TextBox();
            this.slotbox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Storage = new System.Windows.Forms.Label();
            this.Slot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(198, 415);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(106, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(198, 54);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 22);
            this.namebox.TabIndex = 2;
            // 
            // countbox
            // 
            this.countbox.Location = new System.Drawing.Point(198, 82);
            this.countbox.Name = "countbox";
            this.countbox.Size = new System.Drawing.Size(100, 22);
            this.countbox.TabIndex = 3;
            this.countbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // storagebox
            // 
            this.storagebox.Location = new System.Drawing.Point(198, 110);
            this.storagebox.Name = "storagebox";
            this.storagebox.Size = new System.Drawing.Size(100, 22);
            this.storagebox.TabIndex = 4;
            // 
            // slotbox
            // 
            this.slotbox.Location = new System.Drawing.Point(198, 138);
            this.slotbox.Name = "slotbox";
            this.slotbox.Size = new System.Drawing.Size(100, 22);
            this.slotbox.TabIndex = 5;
            this.slotbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(58, 60);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(123, 16);
            this.Name.TabIndex = 6;
            this.Name.Text = "Название товара";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(58, 82);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(101, 16);
            this.Count.TabIndex = 7;
            this.Count.Text = "Кол-во товара";
            // 
            // Storage
            // 
            this.Storage.AutoSize = true;
            this.Storage.Location = new System.Drawing.Point(58, 110);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(47, 16);
            this.Storage.TabIndex = 8;
            this.Storage.Text = "Склад";
            // 
            // Slot
            // 
            this.Slot.AutoSize = true;
            this.Slot.Location = new System.Drawing.Point(58, 138);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(56, 16);
            this.Slot.TabIndex = 9;
            this.Slot.Text = "Ячейка";
            // 
            // DelObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.slotbox);
            this.Controls.Add(this.storagebox);
            this.Controls.Add(this.countbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Name = delobj;
            this.Text = "Удаление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox countbox;
        private System.Windows.Forms.TextBox storagebox;
        private System.Windows.Forms.TextBox slotbox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Storage;
        private System.Windows.Forms.Label Slot;
    }
}