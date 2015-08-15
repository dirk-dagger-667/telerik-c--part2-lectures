using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace ReadingBinaryFileByByte
{
    class BinaryReader
    {
        public static byte[] BinaryFileToByteArray(string pathToFile)
        {
            byte[] fileBytes = File.ReadAllBytes(pathToFile);
            return fileBytes;
        }

        public static void BinaryFileToTextFile(byte[] fileBytes, string pathToTextFile)
        {
            StringBuilder textToString = new StringBuilder();

            for (int i = 0; i < fileBytes.Length; i++)
            {
                textToString.Append(Convert.ToString(fileBytes[i]).PadLeft(8, '0'));
            }

            File.WriteAllText(pathToTextFile, textToString.ToString());
        }

        static void Main(string[] args)
        {
            try
            {
                string pathToBinaryFile = Console.ReadLine();
                string pathToTextFile = Console.ReadLine();
                byte[] binaryToByteArray = BinaryFileToByteArray(pathToBinaryFile);
                BinaryFileToTextFile(binaryToByteArray, pathToTextFile);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("path is null");
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("This operation is not supported on the current platform.\n-or-\npath specified a directory.\n-or-\nThe caller does not have the required permission.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }

            }
    }
}

