using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary
{
    public class IOUtils
    {
        public static string[] FileToArray(string FilePath)
        {
            string[] lines = File.ReadAllLines(FilePath, Encoding.Default);
            return lines;
        }

        public static void ArrayToFile(string path, string[] array)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                string[] line = new string[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    line[i] = array[i];
                    sw.WriteLine(line[i]);
                }
            }
        }

        public static byte [] FileToBytes(string path)
        {
            byte[] fileBytes = File.ReadAllBytes(path);
            return fileBytes;
        }

        public static void BytesToFile(string path, byte [] fileBytes)
        {
            File.WriteAllBytes(path, fileBytes);
        }
    }
}
