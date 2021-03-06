using BusinessCardLib;
using CrediCartLib;
using MoneyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Purse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ruslan
            //----------------------------------------
            BusinessCard BC = new BusinessCard();
            BC.ShowBalance();
            BC.WithdrewMoney(200000);
            BC.ShowBalance();
            BC.PutMoney(50000);
            BC.ShowBalance();
            //----------------------------------------

            // Yurii
            //-------------------------------------------
            Money money = new Money();
            money.Balance = 2000;
            money.Id = "2-356789";
            money.PutMoney(4500);
            money.WithdrawMoney(300);
            Console.WriteLine(money.Balance);
            //-------------------------------------------

            //Natalia//
            //--------------------------------------------
            CrediCart crediCart = new CrediCart();
            crediCart.Name = "Ivan";
            crediCart.Surname = "Ivaniv";
            crediCart.CardNumber = "1234 5678 8901 2345";
            DateTime dt2 = new DateTime(2024, 12, 31);
            DateTime dt1 = new DateTime(2022, 01, 11);
            crediCart.CartTimeStart = dt1;
            crediCart.CartTimeEnd = dt2;
            //--------------------------------------------
        }
    }
}
