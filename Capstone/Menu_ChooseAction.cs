using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Menu_ChooseAction
    {
        public static int ChooseAction(int choice)
        {
            int actionChoice = 0;
            if (choice == 1)
            {
                Action_DisplayVendingMachineItems.DisplayVendingMachineItems();
                return -1;
            }
            else if(choice == 2)
            {
                do
                {
                    Console.WriteLine($"\n1)Feed money\n" +
                        $"2)Select Product\n" +
                        $"3)FinishTransaction\n" +
                        $"Current Money Provide: ${Accounting.MachineBalance}");
                    try
                    {
                        actionChoice = int.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {

                    }
                    if (!Validation.isValid(actionChoice, new int[] { 1, 2, 3 }))
                    {
                        Console.WriteLine("Invalid Entry. Please select 1, 2, 3");
                    }
                } while (!Validation.isValid(actionChoice, new int[] { 1, 2, 3 }));
            }
            else
            {
                actionChoice = 5;
            }
            return actionChoice;
        }
    }
}
