using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Ex_1
{
    public partial class Form_Ex_1 : Form
    {
        public Form_Ex_1()
        {
            InitializeComponent();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Text_Ex_1 In = new Text_Ex_1(OpenFileDialog.FileName);
                    TextBoxIn.Lines = In.Lines;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ошибка входного файла!");
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SaveFileDialog.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    IOUtils.ArrayToFile(SaveFileDialog.FileName, TextBoxOut.Lines);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ошибка конечного файла!");
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonIn_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            Text_Ex_1 f = new Text_Ex_1(OpenFileDialog.FileName);
            TextBoxOut.Lines = f.NewLines(k);            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelIn_Click(object sender, EventArgs e)
        {

        }
    }
}
