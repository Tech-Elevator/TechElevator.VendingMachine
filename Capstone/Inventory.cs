using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Capstone
{
    public static class Inventory
    {
        public static Dictionary<string, Product> InventoryList = new Dictionary<string, Product>();
        public static List<List<string>> inputFileItems = new List<List<string>>();
        public static bool Add()
        {
            bool isAddWorks = true;
            string directory = Environment.CurrentDirectory;
            string file = @"data/vendingmachine.csv";
            string inventoryPath = Path.Combine(directory, file).Replace("Tests", "");
            using (StreamReader reader = new StreamReader(inventoryPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    inputFileItems.Add(line.Split('|').ToList());
                }
            }
            //creating product objects
            for (int i = 0; i < inputFileItems.Count; i++)
            {

               InventoryList.Add(inputFileItems[i][1], new Product(inputFileItems[i][0], inputFileItems[i][1], decimal.Parse(inputFileItems[i][2]), inputFileItems[i][3]));
               if (!InventoryList.ContainsKey(inputFileItems[i][1]))
               {
                    isAddWorks = false;
               }
            }

            //updates sales report totals in dictionary if sales report exists
            if(File.Exists(Record.reportPath))
            {
                using (StreamReader reader = new StreamReader(Record.reportPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split("|");
                        if (InventoryList.ContainsKey(line[0]))
                        {
                            InventoryList[line[0]].salesQuantity = int.Parse(line[1]);
                            if (InventoryList[line[0]].salesQuantity != int.Parse(line[1]))
                            {
                                isAddWorks = false;
                            }
                        }
                    }
                }
            }
            return isAddWorks;
        }
        public static bool RemoveFromStock(Product obj)
        {
            bool isStockRemoved = false;
            int originalStockLevel = obj.StockLevel;
            obj.StockLevel--;

            if(obj.StockLevel == originalStockLevel - 1)
            {
                isStockRemoved = true;
            }
            return isStockRemoved;
        }
    }
}
