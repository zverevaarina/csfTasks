using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Text_Ex_1
    {
        public string Path { get; set; }
        public string [] Lines { get; set; }

        public Text_Ex_1 (string path)
        {
            this.Path = path;
            this.Lines = IOUtils.FileToArray(path);
        }

        public string[] NewLines(int k)
        {
            string[] num = new string[k];
            int index = 0;
            for (int i = Lines.Length - k; i < Lines.Length; i++)
            {
                num[index] = Lines[i];
                index++;
            }
            return num;
        }

    }
}
