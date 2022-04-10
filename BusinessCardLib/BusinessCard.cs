using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardLib
{
    public class BusinessCard
    {
        double balance;
        double putMoney;
        double withdrewMoney;

        public BusinessCard()
        {
            balance = 1000000;
        }

        public void PutMoney(double put)
        {
            putMoney = put;
            balance += putMoney;
        }

        public void WithdrewMoney(double withdrew)
        {
            withdrewMoney = withdrew;
            balance -= withdrewMoney;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"On Balance: {balance}");
        }
    }
}
