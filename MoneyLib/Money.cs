using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public class Money
    {
        public double Balance { get; set; }
        public string Id { get; set; }

        public Money(double balance, string id) =>
            (Balance, Id) = (balance, id);

        public Money()
        {

        }

        public void WithdrawMoney(double sum)
        {
            Balance -= sum;
        }

        public void PutMoney(double sum)
        {
            Balance += sum;
        }
    }
}
