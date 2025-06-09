namespace WindowsFormsApp2
{
    partial class Info
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
            this.Search_item = new System.Windows.Forms.Button();
            this.Search_storage = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.EnterItem = new System.Windows.Forms.TextBox();
            this.NameItem = new System.Windows.Forms.Label();
            this.InfoItem = new System.Windows.Forms.Label();
            this.EneterID = new System.Windows.Forms.TextBox();
            this.InfoStorage = new System.Windows.Forms.Label();
            this.ID_Storage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_item
            // 
            this.Search_item.Location = new System.Drawing.Point(970, 172);
            this.Search_item.Name = "Search_item";
            this.Search_item.Size = new System.Drawing.Size(161, 54);
            this.Search_item.TabIndex = 0;
            this.Search_item.Text = "Вывести ";
            this.Search_item.UseVisualStyleBackColor = true;
            this.Search_item.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search_storage
            // 
            this.Search_storage.Location = new System.Drawing.Point(970, 313);
            this.Search_storage.Name = "Search_storage";
            this.Search_storage.Size = new System.Drawing.Size(161, 54);
            this.Search_storage.TabIndex = 1;
            this.Search_storage.Text = "Вывести ";
            this.Search_storage.UseVisualStyleBackColor = true;
            this.Search_storage.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(970, 533);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 43);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // EnterItem
            // 
            this.EnterItem.Location = new System.Drawing.Point(970, 144);
            this.EnterItem.Name = "EnterItem";
            this.EnterItem.Size = new System.Drawing.Size(160, 22);
            this.EnterItem.TabIndex = 5;
            this.EnterItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameItem
            // 
            this.NameItem.AutoSize = true;
            this.NameItem.Location = new System.Drawing.Point(843, 144);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(123, 16);
            this.NameItem.TabIndex = 6;
            this.NameItem.Text = "Название товара";
            // 
            // InfoItem
            // 
            this.InfoItem.AutoSize = true;
            this.InfoItem.Location = new System.Drawing.Point(871, 108);
            this.InfoItem.Name = "InfoItem";
            this.InfoItem.Size = new System.Drawing.Size(213, 16);
            this.InfoItem.TabIndex = 7;
            this.InfoItem.Text = "Вывести информацию о товаре";
            // 
            // EneterID
            // 
            this.EneterID.Location = new System.Drawing.Point(970, 285);
            this.EneterID.Name = "EneterID";
            this.EneterID.Size = new System.Drawing.Size(160, 22);
            this.EneterID.TabIndex = 8;
            this.EneterID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // InfoStorage
            // 
            this.InfoStorage.AutoSize = true;
            this.InfoStorage.Location = new System.Drawing.Point(872, 243);
            this.InfoStorage.Name = "InfoStorage";
            this.InfoStorage.Size = new System.Drawing.Size(212, 16);
            this.InfoStorage.TabIndex = 10;
            this.InfoStorage.Text = "Вывести информацию о скалде";
            // 
            // ID_Storage
            // 
            this.ID_Storage.AutoSize = true;
            this.ID_Storage.Location = new System.Drawing.Point(843, 291);
            this.ID_Storage.Name = "ID_Storage";
            this.ID_Storage.Size = new System.Drawing.Size(99, 16);
            this.ID_Storage.TabIndex = 13;
            this.ID_Storage.Text = "Номер склада";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(814, 588);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ID_Storage);
            this.Controls.Add(this.InfoStorage);
            this.Controls.Add(this.EneterID);
            this.Controls.Add(this.InfoItem);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.EnterItem);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search_storage);
            this.Controls.Add(this.Search_item);
            this.Name = "Info";
            this.Text = "Информация о товаре";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_item;
        private System.Windows.Forms.Button Search_storage;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox EnterItem;
        private System.Windows.Forms.Label NameItem;
        private System.Windows.Forms.Label InfoItem;
        private System.Windows.Forms.TextBox EneterID;
        private System.Windows.Forms.Label InfoStorage;
        private System.Windows.Forms.Label ID_Storage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}