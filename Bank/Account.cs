using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Bank
{
    public enum BankAccountType
    { corrent, saving }

    public class Account
    {
        private Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        private Guid id;
        private decimal valueOfMoney;
        private BankAccountType type;
        public decimal Money
        {
            get { return valueOfMoney; }
            set { valueOfMoney = value; }
        }

        public static void Dispose(Account account)
        {
            for (int i = 0; i < account.transactions.Count; i++)
            {
                string info = GetInfoAboutTransaction(account.transactions.Dequeue());

                File.AppendAllText("transaction.txt", info + "\n");

            }
            GC.SuppressFinalize(account);
        }
        
        public static string GetInfoAboutTransaction(BankTransaction bankTrans)
        {
            return $" Время выполнения операции {bankTrans.dateTime}; сумма перевода {bankTrans.value} ; тип операции {bankTrans.typeTransaction}";
        }
        public void DepositMoney(decimal depositValue)
        {
            valueOfMoney += depositValue;
            transactions.Enqueue(new BankTransaction(depositValue,BankTransaction.TypeTransaction.Deposit));
        }
        public void WithdrawMoney(decimal withdrawValue)
        {
            if (withdrawValue <= valueOfMoney)
            {
                valueOfMoney -= withdrawValue;
                transactions.Enqueue(new BankTransaction(withdrawValue, BankTransaction.TypeTransaction.Withdraw));
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
                transactions.Enqueue(new BankTransaction(transfer, BankTransaction.TypeTransaction.Transfer));

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
                this.type = BankAccountType.saving;
            }
            else
            {
                this.type = BankAccountType.corrent;
            }

        }

        public Account(BankAccountType type)
        {
            id = Guid.NewGuid();
            if (type.Equals("saving"))
            {
                this.type = BankAccountType.saving;
            }
            else
            {
                this.type = BankAccountType.corrent;
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
