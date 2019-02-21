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
            readFile read = new readFile();
            List<Tradesman> cutList = read.readSpreadSheet(FilePaths.readPath);
            writeFile write = new writeFile();
            write.WriteSpreadSheet(cutList, FilePaths.writePath);
            Console.WriteLine("Truncation complete.");
            Console.Read();
        }
    }
}
