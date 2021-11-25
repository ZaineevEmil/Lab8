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
            string disk = "C:/Test";
            string[] arrayDiskFiles = Directory.GetFiles(disk);
            foreach (string p in arrayDiskFiles)
            {
                Console.WriteLine(p);
            }
            string[] arrayDiskDirectory = Directory.GetDirectories(disk);
            foreach (string p in arrayDiskDirectory)
            {
                Console.WriteLine(p);
                string[] arrayDisk2Files = Directory.GetFiles(p);
                foreach (string pp in arrayDisk2Files)
                {
                    Console.WriteLine(pp);
                }
                string[] arrayDisk2Directory = Directory.GetDirectories(p);
                foreach (string pp in arrayDisk2Directory)
                {
                    Console.WriteLine(pp);
                }
            }
            Console.ReadKey();
        }
    }
}
