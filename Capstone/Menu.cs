using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Menu
    {
        public static void Start()
        {
            //TODO Write tests for all methods 
            
            Accounting.TotalSales = Record.SetTotalSales();
            Inventory.Add();
            while (true)
            {
                Menu_Act.Act(Menu_ChooseAction.ChooseAction(Menu_WelcomeDisplay.WelcomeDisplay()));
            }
        }
    }
}
