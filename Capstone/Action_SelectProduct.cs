using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Action_SelectProduct
    {
        public static int SelectProduct(int test = 1)
        {
            //TODO if not enough money / done back to main menu
            while (true)
            {
                if(test != 1)
                {
                    break;
                }
                Action_DisplayVendingMachineItems.DisplayVendingMachineItems();
                bool isValid = false;
                bool isAvailable = false;
                bool hasEnough = false;
                Console.WriteLine("\nPlease provide desired item number, \"exit\" if done \"back\" to return to main menu");
                string input = Console.ReadLine();
                Validation.exit(input);
                if (input.ToLower().Equals("back"))
                {
                    break;
                }
                foreach (KeyValuePair<string, Product> item in Inventory.InventoryList)
                {
                    isValid = false;
                    isAvailable = false;
                    hasEnough = false;
                    try
                    {
                        if (item.Value.Location.Equals(input.ToUpper().Trim()))
                        {
                            isValid = true;
                        }
                    }
                    catch (System.FormatException)
                    {
                    }
                    if (item.Value.StockLevel > 0)
                    {
                        isAvailable = true;
                    }
                    if ((Accounting.MachineBalance - item.Value.Price) >= 0)
                    {
                        hasEnough = true;
                    }
                    if (isValid)
                    {
                        if (isAvailable && hasEnough)
                        {
                            item.Value.salesQuantity++;
                            Record.LogList.Add(item.Value);
                            Record.AddToSalesReport(item.Value);
                            Inventory.RemoveFromStock(item.Value);
                            Console.WriteLine($"\nYour {item.Value.Name} has been been dispensed. Please take it and enjoy.");
                            Accounting.MachineBalance -= item.Value.Price;
                            Record.AddToLog(item.Value);
                            break;
                        }
                        else
                        {
                            if (!isAvailable)
                            {
                                Console.WriteLine("\nItem you selected is out of stock. " +
                                    "Please select another item.");
                                break;
                            }
                            if (!hasEnough)
                            {
                                Console.WriteLine("\nNot Enough Money. Please Add Money.");
                                break;
                            }
                        }
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("Invalid Number. Please Try Again!");
                }
            }
            Console.Clear();
            return test;
        }
    }
}