namespace Ex_1
{
    partial class Form_Ex_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TextBoxIn = new System.Windows.Forms.TextBox();
            this.ButtonIn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelIn = new System.Windows.Forms.Label();
            this.TextBoxOut = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.MenuToolStripMenuItem.Text = "Меню";
            this.MenuToolStripMenuItem.Click += new System.EventHandler(this.MenuToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.closeToolStripMenuItem.Text = "Сохранить";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // TextBoxIn
            // 
            this.TextBoxIn.Location = new System.Drawing.Point(28, 46);
            this.TextBoxIn.Multiline = true;
            this.TextBoxIn.Name = "TextBoxIn";
            this.TextBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxIn.Size = new System.Drawing.Size(222, 369);
            this.TextBoxIn.TabIndex = 2;
            this.TextBoxIn.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ButtonIn
            // 
            this.ButtonIn.Location = new System.Drawing.Point(267, 106);
            this.ButtonIn.Name = "ButtonIn";
            this.ButtonIn.Size = new System.Drawing.Size(129, 60);
            this.ButtonIn.TabIndex = 2;
            this.ButtonIn.Text = "Оставить k строк";
            this.ButtonIn.UseVisualStyleBackColor = true;
            this.ButtonIn.Click += new System.EventHandler(this.ButtonIn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelIn
            // 
            this.LabelIn.AutoSize = true;
            this.LabelIn.Location = new System.Drawing.Point(264, 46);
            this.LabelIn.Name = "LabelIn";
            this.LabelIn.Size = new System.Drawing.Size(121, 30);
            this.LabelIn.TabIndex = 4;
            this.LabelIn.Text = "Количество строк k\r\n(не более 10):";
            this.LabelIn.Click += new System.EventHandler(this.LabelIn_Click);
            // 
            // TextBoxOut
            // 
            this.TextBoxOut.Location = new System.Drawing.Point(424, 46);
            this.TextBoxOut.Multiline = true;
            this.TextBoxOut.Name = "TextBoxOut";
            this.TextBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxOut.Size = new System.Drawing.Size(222, 369);
            this.TextBoxOut.TabIndex = 5;
            // 
            // Form_Ex_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 458);
            this.Controls.Add(this.TextBoxOut);
            this.Controls.Add(this.LabelIn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonIn);
            this.Controls.Add(this.TextBoxIn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form_Ex_1";
            this.Text = "Form_Ex_1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TextBox TextBoxIn;
        private System.Windows.Forms.Button ButtonIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelIn;
        private System.Windows.Forms.TextBox TextBoxOut;
    }
}

