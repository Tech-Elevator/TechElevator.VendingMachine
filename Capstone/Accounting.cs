using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Accounting
    {
       public static decimal MachineBalance { get; set; }
       public static decimal TotalSales { get; set; }
       public static decimal ReturnChange()
        {
            decimal change = MachineBalance;
            int quarters = 0 ;
            int dimes = 0;
            int nickels = 0;

            while(change >= .25M)
            {
                quarters++;
                change -= .25m;
            }
            while (change >= .10M)
            {
                dimes++;
                change -= .10m;
            }
            while (change >= .05M)
            {
                nickels++;
                change -= .05m;
            }
            Console.WriteLine($"Your change is { quarters} quarters, {dimes} dimes, and {nickels} nickels");
            Console.WriteLine($"Your balance is ${change}");
            return change;    
        } 
    }
}
