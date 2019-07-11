using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public enum CategoryType
    {
         Income, Expend
    }
    public class AccountItem
    {
        public string Name
        {
            get; set;
        }
        public CategoryType Category
        {
            get;set;
        }
        public string Content
        {
            get;set;
        }
        public string Note
        {
            get;set;
        }
        public Money Amount
        {
            get;set;
        }
        public DateTime OccuredTime
        {
            get;set;
        }        public AccountItem(string Name, CategoryType Category, Money Amount, DateTime OccuredTime, string Content = "",string Note = "")
        {
            this.Name = Name;
            this.Category = Category;
            this.Amount = Amount;
            this.OccuredTime = OccuredTime;
            this.Content = Content;
            this.Note = Note;
        }
        public AccountItem(string Name, CategoryType Category, Money Amount, string Content = "", string Note = ""):this(Name, Category, Amount, DateTime.Now.Date, Content, Note) { }
        //{
        //    this.Name = Name;
        //    this.Category = Category;
        //    this.Amount = Amount;
        //    this.OccuredTime = DateTime.Now.Date;
        //    this.Content = Content;
        //    this.Note = Note;
        //}
        public override string ToString()
        {
            if(Category == CategoryType.Expend)
            {
                return $"{Name} {OccuredTime.ToString("d")} 支出 {Amount}  Content: {Content}  Note: {Note}";
            }
            else
            {
                return $"{Name} {OccuredTime.ToString("d")} 收入 {Amount}  Content: {Content}  Note: {Note}";
            }
        }
        
    }
}
