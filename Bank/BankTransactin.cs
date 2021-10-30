using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    class BankTransaction
    {
        public decimal value { get; private set; }
        public BankTransaction()
        {

        }
        public BankTransaction(decimal value)
        {
            this.value = value;
            Console.WriteLine($"В {DateTime.Now} было переведено {value} долларов!");

        }
    }
}