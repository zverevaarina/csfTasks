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

namespace Ex_2
{
    public partial class Form_Ex_2 : Form
    {
        static File_Ex_2 file;
        public Form_Ex_2()
        {
            InitializeComponent();
        }

        private void Form_Ex_2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File_Ex_2 file = new File_Ex_2(openFileDialog.FileNames);
                    labelOpen.Text = "Файлы загружены";
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ошибка входных файлов!");
                }
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            File_Ex_2 file = new File_Ex_2(openFileDialog.FileNames);
            file.Swap();
            labelSwap.Text = "Программа завершила работу";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IOUtils.BytesToFile(saveFileDialog1.FileName, file.FileText2);
                    labelSave1.Text = "Файл сохранен";
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ошибка конечного файла!");
                }
            }
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IOUtils.BytesToFile(saveFileDialog2.FileName, file.FileText2);
                    labelSave2.Text = "Файл сохранен";
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ошибка конечного файла!");
                }
            }
        }

        private void labelOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
