using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Capstone
{
    public static class Validation
    {
        public static bool isValid(int choice, int[] comparison)
        {
            if (comparison == null)
            {
                return false;
            }

            int index = 0;
            while(index < comparison.Length)
            {
                if(choice == (comparison[index]))
                {
                    return true;
                }
                index++;
            }
            return false;
        }

        public static int exit(string exit)
        {
            if(exit == null)
            {
                return 0;
            }
            else if (exit.ToLower().Trim().Equals("exit"))
            {
                string[] exitMessage = "Come Again Soon!".Split(" ");
                int index = 0;

                while (index < exitMessage.Length)
                {
                    Console.Write($"{exitMessage[index]} ");
                    Thread.Sleep(500);
                    index++;
                }
                Environment.Exit(0);
                return 1;
            }
            return 0;
        }
    } 
}
