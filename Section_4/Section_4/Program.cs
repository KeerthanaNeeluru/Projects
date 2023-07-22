using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section_4
{
    internal class Program
    {
        public static void readfile(string fname, string path)
        {
            string fpath = path + fname;
            /*StreamReader sr = new StreamReader(fpath);
            string text = "";
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            sr.Close();*/
            if (File.Exists(fpath))
            {
                string[] lines = File.ReadAllLines(fpath);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Keerthana\\OneDrive\\Desktop\\job\\simpli\\Projects\\Section_4\\";
            string fname = "stu_data.txt";
            readfile(fname, path);
            Console.ReadKey();

        }
    }
}
