using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexresProject
{
    
    class WriteRead
    {
        public interface AS
        {
            void Data();
            WriteRead data();
            int sttt();
            //void ch()
            //{

            //}
        }
        int id;
        string name;
        string add;
        double weight;

        public WriteRead(int id, string name, string add, double weight)
        {
            this.id = id;
            this.name = name;
            this.add = add;
            this.weight = weight;
        }
        public void FileWriteInfo()
        {
            try
            {
                FileInfo file = new FileInfo("E:\\abc1.txt");
                StreamWriter sw = file.CreateText();
                sw.WriteLine("name is : " + this.name);
                sw.WriteLine("id is : "+ this.id);
                sw.WriteLine("weight is : " + this.weight);
                sw.WriteLine("address is : " + this.add);
                sw.Close();
            }
            catch (IOException ex) { Console.WriteLine(ex.Message); }
        }
        public void FileReadInfo()
        {
            try
            {
                FileInfo file = new FileInfo("E:\\BizRun.NET\\abc4.txt");
                StreamReader sr = file.OpenText();
                Console.WriteLine("id is : " + this.id);
                Console.WriteLine("name is : " + this.name);
                Console.WriteLine("address is : " + this.add);
                Console.WriteLine("weight is : " + this.weight);
            }
            catch (IOException e) { Console.WriteLine("Something went wrong: " + e); }
        }
        static void Main(string[] args)
        {
            WriteRead wr = new WriteRead(123, "Razi", "dbg", 64.50);
            wr.FileWriteInfo();
            wr.FileReadInfo();
            Console.ReadKey();
        }
    }
}
