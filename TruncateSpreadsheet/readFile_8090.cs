using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruncateSpreadsheet
{
    class readFile_8090 : readFile
    {
        public List<List<Tradesman>> produce8090List(List<List<Tradesman>> collection)
        {
            List<List<Tradesman>> eightyNinety = new List<List<Tradesman>>();
            for(int i=0; i< collection.Count;i++)
            {
                List<Tradesman> tradeSheet = new List<Tradesman>();
                foreach(Tradesman tradesman in collection[i])
                {
                    if((DateTime.Parse(tradesman.ExpirationDate).Subtract(DateTime.Today).Days) >= 80 && (DateTime.Parse(tradesman.ExpirationDate).Subtract(DateTime.Today).Days <= 90))
                    {
                        tradeSheet.Add(tradesman);
                    }
                }
                eightyNinety.Add(tradeSheet);
            }
            return eightyNinety;
        }
    }
}
