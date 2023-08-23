using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Menu_WelcomeDisplay
    {
        public static int WelcomeDisplay(int choice = 0)
        {
            bool isValid;
            do
            {
                if(choice != 0)
                {
                    break;
                }
                Console.WriteLine("\n1)Display Vending Machine\n2)Purchase\n or exit if you are finished snacking ");
                string input = Console.ReadLine();
                Validation.exit(input);
                try
                {
                    choice = int.Parse(input);
                }
                catch (System.FormatException)
                {
                }
                isValid = Validation.isValid(choice, new int[] { 1, 2});
                if (!isValid)
                {
                    Console.WriteLine("Not a Valid Entry. Select 1, 2");
                }
            } while (!isValid);
            return choice;
        }
    }
}
