using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C:/Users/zaine/Desktop/BIM study";
            Console.WriteLine(Directory.GetFiles(path));
            string[] arrayDisk = Directory.GetDirectories(path);
            foreach (string d in arrayDisk)
            {
                Console.WriteLine(Directory.GetFiles(d));
            }

            Console.ReadKey();




        }
    }
}
