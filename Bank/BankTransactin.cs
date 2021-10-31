using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public class BankTransaction
    {
        public readonly decimal value;
        public readonly DateTime dateTime = new DateTime();
        public readonly TypeTransaction typeTransaction;
        public enum TypeTransaction
        {
            Withdraw,
            Deposit,
            Transfer
        }
        public BankTransaction()
        {

        }
        public BankTransaction(decimal value, TypeTransaction typeTransaction)
        {
            this.value = value;
            dateTime = DateTime.Now;
            this.typeTransaction = typeTransaction;
        }
    }
}