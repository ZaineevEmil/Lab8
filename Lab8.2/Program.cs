using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fs = new FileInfo("Number.txt");
            FileStream newFile = fs.Create();
            newFile.Close();
            string path = "Number.txt";
            const int n = 10;
            int[] randomNum = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                randomNum[i] = random.Next();
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.Write(Convert.ToString(randomNum[i]));
                    sw.Write(" ");
                }
            }
            string num = "";
            double sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                num = sr.ReadToEnd();
            }
            string[] numArray = num.Split();
            for (int i = 0; i < n; i++)
            {
                sum = sum + Convert.ToDouble(numArray[i]);
            }
            Console.WriteLine("{0}", sum);
            Console.ReadKey();
        }
    }
}
