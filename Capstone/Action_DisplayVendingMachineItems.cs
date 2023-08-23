using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Action_DisplayVendingMachineItems
    {
        public static int DisplayVendingMachineItems()
        {
            Console.WriteLine("\nName\t\t    Location\tPrice\tQuantity");
            Console.WriteLine("----------------------------------------------------------");

            foreach (KeyValuePair<string, Product> item in Inventory.InventoryList)
            {
                if (item.Value.StockLevel <= 0)
                {
                    Console.WriteLine($"" +
                        $"{item.Value.Name.PadRight(20)}" +
                        $"\t{item.Value.Location}" +
                        $"\t${item.Value.Price}" +
                        $"\tSOLD OUT");
                }
                else
                {
                    Console.WriteLine($"" +
                        $"{item.Value.Name.PadRight(20)}    " +
                        $"{item.Value.Location.PadRight(8)}" +
                        $"${item.Value.Price.ToString().PadRight(8)}" +
                        $"{item.Value.StockLevel}");
                }
            }
            return -1;
        }
    }
}
