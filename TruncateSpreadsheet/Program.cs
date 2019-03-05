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
            readFile_8090 read = new readFile_8090();
            List<List<Tradesman>> cutList = read.readSpreadSheet(FilePaths.readPath);
            List<List<Tradesman>> tradesmanList_8090 = read.produce8090List(cutList);
            writeFile write = new writeFile();
            write.WriteSpreadSheet(tradesmanList_8090, FilePaths.writePath);
            Console.WriteLine("Truncation complete.");
            Console.Read();
        }
    }
}
