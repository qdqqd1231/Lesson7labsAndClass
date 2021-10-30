using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public enum BankAccountType
    { corrent, saving }

    public class Account
    {
        private static Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        private Guid id;
        private decimal valueOfMoney;
        private BankAccountType type;
        public decimal Money
        {
            get { return valueOfMoney; }
            set { valueOfMoney = value; }
        }

        public static void ShowTransactions()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"В {DateTime.Now} было переведено {transaction.value} долларов!");
            }
        }
        public void DepositMoney(decimal depositValue)
        {
            valueOfMoney += depositValue;
            transactions.Enqueue(new BankTransaction(depositValue));
        }
        public void WithdrawMoney(decimal withdrawValue)
        {
            if (withdrawValue <= valueOfMoney)
            {
                valueOfMoney -= withdrawValue;
                transactions.Enqueue(new BankTransaction(withdrawValue));
            }
            else
            {
                Console.WriteLine("insufficient funds");
            }

        }

        public void Transfer(Account acc, decimal transfer)
        {
            if (transfer <= valueOfMoney)
            {
                this.valueOfMoney -= transfer;
                acc.Money += transfer;
                transactions.Enqueue(new BankTransaction(transfer));

            }
            else
            {
                Console.WriteLine("insufficient funds");
            }
        }

        public Account()
        {

        }

        public Account(BankAccountType type, decimal newValue)
        {
            id = Guid.NewGuid();
            valueOfMoney = newValue;
            if (type.Equals("saving"))
            {
                type = BankAccountType.saving;
            }
            else
            {
                type = BankAccountType.corrent;
            }

        }

        public Account(BankAccountType type)
        {
            id = Guid.NewGuid();
            if (type.Equals("saving"))
            {
                type = BankAccountType.saving;
            }
            else
            {
                type = BankAccountType.corrent;
            }

        }
        public Account(decimal newValue)
        {

            id = Guid.NewGuid();
            valueOfMoney = newValue;

        }

        public void WriteTheData()
        {
            Console.WriteLine($"Type:{type} \n ID : {id} \n Value of money : {valueOfMoney}");
        }

    }
}
