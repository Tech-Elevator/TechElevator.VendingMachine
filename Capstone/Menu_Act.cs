using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public static class Menu_Act
    {
        public static bool Act(int choice)
        {
            bool isActWorking = false;
            if(choice != 1 && choice != 2 && choice != 3)
            {
                isActWorking = true;
            }
            switch (choice)
            {
                case 1:
                    Action_FeedMoney.FeedMoney();
                    break;
                case 2:
                    Action_SelectProduct.SelectProduct();
                    break;
                case 3:
                    Action_FinishTransaction.FinishTransaction(1);
                    break;
            }
            return isActWorking;
        }
    }
}
