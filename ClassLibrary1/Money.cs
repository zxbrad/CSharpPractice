using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public enum MoneyType { RMB = 0,  USD = 1, EUR = 2 }
    public class Money
    {
        public double MoneyValue {
            get;set;
        }
        public MoneyType type
        {
            get;set;
        }
        public double RmbValue
        {
            get{
                switch (this.type)
                {
                    case MoneyType.USD:
                        return this.MoneyValue * 6.92;
                    case MoneyType.EUR:
                        return this.MoneyValue * 7.76;
                    default:
                        return this.MoneyValue;

                }
            }
        }
        public Money(double MoneyValue)
        {
            this.MoneyValue = MoneyValue;
            this.type = MoneyType.RMB;
        }
        public Money(double MoneyValue, MoneyType type)
        {
            this.MoneyValue = MoneyValue;
            this.type = type;
        }
        public static Money operator+ (Money m1, Money m2)
        {
            if(m1.type != m2.type && m1.MoneyValue!=0)
            {
                return new Money(m1.RmbValue + m2.RmbValue);
            }
            else
            {
                return new Money(m1.MoneyValue + m2.MoneyValue, m2.type);
            }
        }
        public static Money operator- (Money m1, Money m2)
        {
            if (m1.type != m2.type && m1.MoneyValue != 0)
            {
                return new Money(m1.RmbValue - m2.RmbValue);
            }
            else
            {
                return new Money(m1.MoneyValue - m2.MoneyValue, m2.type);
            }
        }
        public override string ToString()
        {
            return $"{MoneyValue} {type}";
        }
    }
}
