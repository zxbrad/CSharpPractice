using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountItem item1 = new AccountItem("item1", CategoryType.Expend, new Money(100), new DateTime(2019, 5, 6), Note: "sad" );
            AccountItem item2 = new AccountItem("item2", CategoryType.Expend, new Money(300), new DateTime(2019, 5, 8));
            AccountItem item3 = new AccountItem("item2", CategoryType.Income, new Money(50), new DateTime(2019, 5, 15));
            AccountItem item4 = new AccountItem("item3", CategoryType.Expend, new Money(500), new DateTime(2019, 3, 8));
            AccountItem item5 = new AccountItem("item4", CategoryType.Expend, new Money(700, MoneyType.USD), new DateTime(2019, 3, 2));
            Accounts account = new Accounts();
            account.addItem(item1);
            account.addItem(item2);
            account.addItem(item3);
            account.addItem(item4);
            account.addItem(item5);
            int month = 5;
            DateTime OccuredTime = new DateTime(2019, month, 1);
            Console.WriteLine($"Total Revenue in {OccuredTime} is {account.TotalRevenue(OccuredTime)}");
            Console.WriteLine($"Total Income in {OccuredTime} is {account.TotalIncome(OccuredTime)}");
            Console.WriteLine($"Total Expend in {OccuredTime} is {account.TotalExpend(OccuredTime)}");
            foreach (AccountItem item in account.Display(OccuredTime))
            {
                Console.WriteLine(item);
            }
           

            
            //Console.WriteLine("123");
        }
    }
}
