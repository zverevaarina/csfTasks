namespace Ex_2
{
    partial class Form_Ex_2
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelSwap = new System.Windows.Forms.Label();
            this.labelSave1 = new System.Windows.Forms.Label();
            this.labelSave2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(122, 35);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Загрузить";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(12, 53);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(122, 70);
            this.buttonSwap.TabIndex = 1;
            this.buttonSwap.Text = "Замена";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonSave1
            // 
            this.buttonSave1.Location = new System.Drawing.Point(12, 129);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(122, 35);
            this.buttonSave1.TabIndex = 2;
            this.buttonSave1.Text = "Сохранить файл 1";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "saveFileDialog1";
            // 
            // buttonSave2
            // 
            this.buttonSave2.Location = new System.Drawing.Point(12, 170);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(122, 35);
            this.buttonSave2.TabIndex = 4;
            this.buttonSave2.Text = "Сохранить файл 2";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "saveFileDialog2";
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Location = new System.Drawing.Point(161, 21);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(10, 13);
            this.labelOpen.TabIndex = 5;
            this.labelOpen.Text = "-";
            this.labelOpen.Click += new System.EventHandler(this.labelOpen_Click);
            // 
            // labelSwap
            // 
            this.labelSwap.AutoSize = true;
            this.labelSwap.Location = new System.Drawing.Point(161, 62);
            this.labelSwap.Name = "labelSwap";
            this.labelSwap.Size = new System.Drawing.Size(10, 13);
            this.labelSwap.TabIndex = 6;
            this.labelSwap.Text = "-";
            // 
            // labelSave1
            // 
            this.labelSave1.AutoSize = true;
            this.labelSave1.Location = new System.Drawing.Point(161, 140);
            this.labelSave1.Name = "labelSave1";
            this.labelSave1.Size = new System.Drawing.Size(10, 13);
            this.labelSave1.TabIndex = 7;
            this.labelSave1.Text = "-";
            // 
            // labelSave2
            // 
            this.labelSave2.AutoSize = true;
            this.labelSave2.Location = new System.Drawing.Point(161, 181);
            this.labelSave2.Name = "labelSave2";
            this.labelSave2.Size = new System.Drawing.Size(10, 13);
            this.labelSave2.TabIndex = 8;
            this.labelSave2.Text = "-";
            // 
            // Form_Ex_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 242);
            this.Controls.Add(this.labelSave2);
            this.Controls.Add(this.labelSave1);
            this.Controls.Add(this.labelSwap);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.buttonSave1);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form_Ex_2";
            this.Text = "Form_Ex_2";
            this.Load += new System.EventHandler(this.Form_Ex_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelSwap;
        private System.Windows.Forms.Label labelSave1;
        private System.Windows.Forms.Label labelSave2;
    }
}

