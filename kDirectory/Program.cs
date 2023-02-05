using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju direktorija: ");
            string dir = Console.ReadLine();

            if (Directory.Exists(dir))
            {
                Console.WriteLine("\r\nDatoteke:");
                for (int i = 0; i < Directory.GetFiles(dir).Length; i++)
                {
                    Console.WriteLine(Directory.GetFiles(dir)[i]);
                }
            }

            string sideDir = "\\TEST";
            string newDir = dir + sideDir;

            if (!Directory.Exists(newDir))
            {
                Directory.CreateDirectory(newDir);
            }
            else
            {
                Console.WriteLine("\r\nDirektoriju \"{0}\" postoji več!",sideDir);
            }

            Console.WriteLine("\r\nDirektorije:");
            for(int i = 0; i < Directory.GetDirectories(dir).Length; i++)
            {
                Console.WriteLine(Directory.GetDirectories(dir)[i]);
            }

            Directory.Delete(newDir);

            Console.WriteLine("\r\nNakon brizanja:");
            for (int i = 0; i < Directory.GetDirectories(dir).Length; i++)
            {
                Console.WriteLine(Directory.GetDirectories(dir)[i]);
            }
            Console.ReadKey();
        }
    }
}
