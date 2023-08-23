using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public static class Record
    {
        public static decimal totalSales { get; set; }
        public static List<Product> LogList = new List<Product>();
        public static string Directory = Environment.CurrentDirectory;
        public static string logFile = @"data/log.txt";
        public static string reportFile = @"data/salesreport.txt";
        public static string logPath = Path.Combine(Directory, logFile);
        public static string reportPath = Path.Combine(Directory, reportFile);

        public static bool AddToLog(string input, decimal money)
        {
            bool isAddingToLog = false;
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"" +
                    $"{DateTime.UtcNow} " +
                    $"{input} " +
                    $"${money} " +
                    $"${Accounting.MachineBalance}");
            }
            using (StreamReader reader = new StreamReader(logPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.Contains($"" +
                    $"{DateTime.UtcNow} " +
                    $"{input} " +
                    $"${money} " +
                    $"${Accounting.MachineBalance}"))
                    {
                        isAddingToLog = true;
                    }
                }
            }
            return isAddingToLog;
        }
        public static bool AddToLog(Product saleItem)
        {
            bool isAddingToLog = false;
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"" +
                    $"{DateTime.UtcNow} " +
                    $"{saleItem.Name} " +
                    $"{saleItem.Location}" +
                    $" ${saleItem.Price}" +
                    $" ${Accounting.MachineBalance}");
            }
            using (StreamReader reader = new StreamReader(logPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.Contains($"" +
                    $"{DateTime.UtcNow} " +
                    $"{saleItem.Name} " +
                    $"{saleItem.Location}" +
                    $" ${saleItem.Price}" +
                    $" ${Accounting.MachineBalance}"))
                    {
                        isAddingToLog = true;
                    }
                }
                return isAddingToLog;
            }
        }

            public static decimal SetTotalSales(string parsePath = "** $100")
            {
                
                decimal previousTotalValue = 0.00M;
                if (!parsePath.Equals("** $100"))
                {
                    string line = parsePath;
                    string[] lineSplit = line.Split("** $");
                    previousTotalValue = decimal.Parse(lineSplit[1]);
                } else
                {
                    if (File.Exists(reportPath))
                    {
                        using (StreamReader reader = new StreamReader(reportPath))
                        {
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();

                                if (line.Contains("TOTAL SALES"))
                                {
                                    string[] lineSplit = line.Split("** $");
                                    previousTotalValue = decimal.Parse(lineSplit[1]);
                                }
                            }
                        }
                    }
                }
                return previousTotalValue;
            }
            public static void AddToSalesReport(Product item)
            {
                using (StreamWriter writer = new StreamWriter(reportPath, false))
                {
                    totalSales += item.Price;
                    foreach (KeyValuePair<string, Product> inventoryItem in Inventory.InventoryList)
                    {
                        writer.WriteLine($"" +
                            $"{inventoryItem.Value.Name}|" +
                            $"{inventoryItem.Value.salesQuantity}");
                    }
                    writer.WriteLine($"**TOTAL SALES** " +
                        $"${Accounting.TotalSales + totalSales}");
                }
            }
        }
    }
