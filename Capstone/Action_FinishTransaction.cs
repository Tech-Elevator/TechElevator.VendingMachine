using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Action_FinishTransaction
    {
        public static int FinishTransaction(int choice)
        {
            decimal returnedChange = Accounting.MachineBalance;
            foreach (Product logItem in Record.LogList)
            {
                Console.WriteLine($"\n{ logItem.stringValue}");
            }
            Accounting.ReturnChange();
            Accounting.MachineBalance = 0M;
            Record.AddToLog("Give Change", returnedChange);
            return choice;
        }
    }
}
