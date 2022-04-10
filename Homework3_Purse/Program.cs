using BusinessCardLib;
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
        }
    }
}
