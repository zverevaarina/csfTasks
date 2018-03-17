using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class File_Ex_2
    {
        public string[] Path { get; set; }
        public byte[] FileText1 { get; set; }
        public byte[] FileText2 { get; set; }

        public File_Ex_2(string [] path)
        {
            this.Path = path;
            this.FileText1 = IOUtils.FileToBytes(path[0]);
            this.FileText2 = IOUtils.FileToBytes(path[1]);

        }

        public void Swap(/*byte[] FileText1, byte[] FileText2*/)
        {
            if (FileText1.Length > FileText2.Length)
            {
                byte[] tmp = new byte [FileText1.Length];
                tmp = FileText1;
                FileText1 = FileText2;
                FileText2 = tmp;

            }
            else
            {
                byte[] tmp = new byte[FileText2.Length];
                tmp = FileText2;
                FileText2 = FileText1;
                FileText1 = tmp;
            }
        }
    }
}
