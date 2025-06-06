namespace WindowsFormsApp2
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.watch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(113, 95);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(158, 65);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить предмет(-ы)";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(113, 237);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(158, 65);
            this.delete.TabIndex = 1;
            this.delete.Text = "Удалить предмет(-ы)";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // watch
            // 
            this.watch.Location = new System.Drawing.Point(113, 166);
            this.watch.Name = "watch";
            this.watch.Size = new System.Drawing.Size(158, 65);
            this.watch.TabIndex = 2;
            this.watch.Text = "Просмотреть предмет(-ы)";
            this.watch.UseVisualStyleBackColor = true;
            this.watch.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 431);
            this.Controls.Add(this.watch);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "MainMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button watch;
    }
}

