using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary.AccountExtension;

namespace AccountLibrary
{
    public delegate bool FilterHandler(AccountItem item);
    public class Accounts
    {
        private List<AccountItem> Item = new List<AccountItem>(); 
        public void addItem(AccountItem Item)
        {
            this.Item.Add(Item);
        }
        public Money TotalRevenue(DateTime time)
        {
            Money Total = new Money(0);
            foreach(AccountItem acItem in this.Item)
            {
                //if (acItem.OccuredTime.Month == time.Month && acItem.OccuredTime.Year == time.Year)
                if(time.SameMonthOfSameYear(acItem.OccuredTime))
                {
                    if (acItem.Category == CategoryType.Income)
                    {
                        Total += acItem.Amount;
                    }
                    else
                    {
                        Total -= acItem.Amount;
                    }
                }
            }
            return Total;
        }
        public Money CalculateMoney(FilterHandler filter)
        {
            Money Total = new Money(0);
            foreach(AccountItem acItem in this.Item)
            {
                if(filter(acItem))
                {
                    Total += acItem.Amount;
                }
            }
            return Total;
        }
        public Money TotalExpend(DateTime time)
        {
            return CalculateMoney(item => time.SameMonthOfSameYear(item.OccuredTime) && item.Category == CategoryType.Expend);

        }
        public Money TotalIncome(DateTime time)
        {
            return CalculateMoney(item => time.SameMonthOfSameYear(item.OccuredTime) && item.Category == CategoryType.Income);
        }
        public IEnumerable<AccountItem> Display(DateTime time)
        {
            foreach (AccountItem acItem in this.Item)
            {
                if (acItem.OccuredTime.Month == time.Month)
                {
                    yield return acItem;
                }
            }
        }
        public IEnumerable<AccountItem> Display()
        {
            foreach (AccountItem acItem in this.Item)
            {
                    yield return acItem;
            }
        }

    }
}
