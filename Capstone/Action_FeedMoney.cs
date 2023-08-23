using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Action_FeedMoney
    {
        public static int FeedMoney(int test = 1)
        {
            while (true)
            {
                if(test == 0)
                {
                    break;
                }
                Console.WriteLine("Please Provide Whole Dollar Amount, \"exit\" if done \"back\" to return to main menu");
                string line = Console.ReadLine();
                decimal input = 0;
                Validation.exit(line);
                if (line.ToLower().Equals("back"))
                {
                    break;
                }
                try
                {
                    input = decimal.Parse(line);
                }
                catch (System.FormatException)
                {
                }
                if (input % 1 != 0 || input <= 0)
                {
                    Console.WriteLine("Not Whole Dollar Amount. Try Again");
                    continue;
                }
                if (Accounting.MachineBalance + input > 500.00M)
                {
                    Console.WriteLine("Maximum Machine Balance Reached");
                    continue;
                }
                Accounting.MachineBalance += input;
                Record.AddToLog("FEED MONEY", input);
                Console.WriteLine($"\nCurrent Money Provided is ${Accounting.MachineBalance}");
            }
            return test;
        }
    }
}