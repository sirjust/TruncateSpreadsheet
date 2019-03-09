using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruncateSpreadsheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program can truncate the master spreadsheet in one of two ways.");
            bool correctSelection = false;
            while (!correctSelection)
            {
                Console.WriteLine("To produce a spreadsheet from 0-90 days, press 1.");
                Console.WriteLine("To produce a sheet for 80-90 days, press 2.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        {
                            readFile read = new readFile();
                            List<List<Tradesman>> cutList = read.readSpreadSheet(FilePaths.readPath);
                            writeFile write = new writeFile();
                            write.WriteSpreadSheet(cutList, FilePaths.writePath);
                            correctSelection = true;
                            break;
                        }
                    case "2":
                        {
                            readFile_8090 read = new readFile_8090();
                            List<List<Tradesman>> cutList = read.readSpreadSheet(FilePaths.readPath);
                            List<List<Tradesman>> tradesmanList_8090 = read.produce8090List(cutList);
                            writeFile write = new writeFile();
                            write.WriteSpreadSheet(tradesmanList_8090, FilePaths.writePath);
                            correctSelection = true;
                            break;
                        }
                    default:
                        Console.WriteLine("Please enter 1 or 2.");
                        break;
                }
            }
            Console.WriteLine("Truncation complete.");
            Console.Read();
        }
    }
}
