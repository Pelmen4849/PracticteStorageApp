namespace WindowsFormsApp2
{
    partial class AddExciste
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
        private void InitializeComponent(System.Windows.Forms.Label addex)
        {
            this.slotbox = new System.Windows.Forms.TextBox();
            this.storagebox = new System.Windows.Forms.TextBox();
            this.countbox = new System.Windows.Forms.TextBox();
            this.Slot = new System.Windows.Forms.Label();
            this.Storage = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slotbox
            // 
            this.slotbox.Location = new System.Drawing.Point(183, 137);
            this.slotbox.Name = "slotbox";
            this.slotbox.Size = new System.Drawing.Size(100, 22);
            this.slotbox.TabIndex = 21;
            // 
            // storagebox
            // 
            this.storagebox.Location = new System.Drawing.Point(183, 98);
            this.storagebox.Name = "storagebox";
            this.storagebox.Size = new System.Drawing.Size(100, 22);
            this.storagebox.TabIndex = 20;
            // 
            // countbox
            // 
            this.countbox.Location = new System.Drawing.Point(183, 53);
            this.countbox.Name = "countbox";
            this.countbox.Size = new System.Drawing.Size(100, 22);
            this.countbox.TabIndex = 19;
            this.countbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Slot
            // 
            this.Slot.AutoSize = true;
            this.Slot.Location = new System.Drawing.Point(34, 137);
            this.Slot.Name = "Slot";
            this.Slot.Size = new System.Drawing.Size(76, 16);
            this.Slot.TabIndex = 18;
            this.Slot.Text = "Ячейка(-и)";
            // 
            // Storage
            // 
            this.Storage.AutoSize = true;
            this.Storage.Location = new System.Drawing.Point(34, 98);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(47, 16);
            this.Storage.TabIndex = 17;
            this.Storage.Text = "Склад";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(34, 59);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(112, 16);
            this.Count.TabIndex = 16;
            this.Count.Text = "Количество(ед.)";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(34, 16);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(73, 16);
            this.Name.TabIndex = 15;
            this.Name.Text = "Название";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(183, 16);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 22);
            this.namebox.TabIndex = 14;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(37, 224);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(179, 224);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(104, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddExciste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 278);
            this.Controls.Add(this.slotbox);
            this.Controls.Add(this.storagebox);
            this.Controls.Add(this.countbox);
            this.Controls.Add(this.Slot);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Add);
            this.Name = addex;
            this.Text = "Добавить к существующему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slotbox;
        private System.Windows.Forms.TextBox storagebox;
        private System.Windows.Forms.TextBox countbox;
        private System.Windows.Forms.Label Slot;
        private System.Windows.Forms.Label Storage;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Add;
    }
}