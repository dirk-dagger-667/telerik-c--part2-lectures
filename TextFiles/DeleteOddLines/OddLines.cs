using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOddLines
{
    class OddLines
    {
        static void RemoveOddLinesFromFile(string filePath)
        {
            FileStream oStream = new FileStream(filePath,FileMode.Open, FileAccess.Write, FileShare.Read);
            FileStream iStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            StreamReader reader = new StreamReader(iStream);
            StreamWriter writer = new StreamWriter(oStream);
            string line;
            string nullString = " ";

            while ((line = reader.ReadLine()) != null)
            {
                line = reader.ReadLine();
                writer.WriteLine(line);
                writer.WriteLine(nullString);
            }

            reader.Close();
            writer.Close();
            oStream.Close();
            iStream.Close();
        }

        static void Main(string[] args)
        {
            string pathOfFile = Console.ReadLine();
            RemoveOddLinesFromFile(pathOfFile);
        }
    }
}
