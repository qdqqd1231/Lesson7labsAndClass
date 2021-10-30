using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Сколько денег на сбер счету?-->");
            decimal money;
            while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            {
                Console.WriteLine("Incorrect input money");
            }
            Account save = new Account(BankAccountType.saving, money);
            money = 0;
            Console.Write("Сколько денег на текущем счету?-->");
            while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            {
                Console.WriteLine("Incorrect input money");
            }
            Account corrent = new Account(BankAccountType.corrent, money);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select action :<show bank transactions> <show correct> or <show saving> <deposit> or <withdraw> money, <transfer> or <exit> to exit the program : ");
                string type = Console.ReadLine().ToLower();
                if (type.Equals("exit"))
                {
                    flag = false;
                }
                else if (type.Equals("show bank transactions"))
                {
                    Account.ShowTransactions();
                    //Console.WriteLine("corrent or saving?");
                    //string str = Console.ReadLine();
                    //if (str.Equals("corrent"))
                    //{
                       
                    //}
                    //else if (str.Equals("saving"))
                    //{

                    //}
                }
                else if (type.Equals("transfer"))
                {
                    Console.WriteLine("from corrent or saving?");
                    string str = Console.ReadLine();
                    if (Equals(str, "save"))
                    {
                        Console.WriteLine("How much?");
                        decimal transfer;
                        while (!decimal.TryParse(Console.ReadLine(), out transfer) || transfer < 0)
                        {
                            Console.WriteLine("Incorrect value of money");
                        }
                        save.Transfer(corrent, transfer);


                    }
                    if (Equals(str, "corrent"))
                    {
                        Console.WriteLine("How much?");
                        decimal transfer;
                        while (!decimal.TryParse(Console.ReadLine(), out transfer) || transfer < 0)
                        {
                            Console.WriteLine("Incorrect value of money");
                        }
                        corrent.Transfer(save, transfer);
                    }

                }
                else if (type.Equals("show corrent"))
                {
                    corrent.WriteTheData();
                }
                else if (type.Equals("show saving"))
                {
                    save.WriteTheData();
                }
                else if (type.Equals("deposit"))
                {
                    Console.Write("Choose the type of account : saving or corrent\t\t");
                    string type0 = Console.ReadLine().ToLower();
                    if (type0.Equals("saving"))
                    {
                        Console.Write("enter volue : ");
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        save.DepositMoney(money);
                    }
                    else if (type0.Equals("corrent"))
                    {
                        Console.Write("enter volue : ");
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        corrent.DepositMoney(money);
                    }
                }
                else if (type.Equals("withdraw"))
                {
                    Console.Write("Choose the type of account : saving or corrent\t\t");
                    string type0 = Console.ReadLine().ToLower();
                    if (type0.Equals("saving"))
                    {
                        Console.Write("enter volue : ");
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        save.WithdrawMoney(money);
                    }
                    else if (type0.Equals("corrent"))
                    {
                        Console.Write("enter volue : ");
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        corrent.WithdrawMoney(money);
                    }
                }

            }
            Console.Clear();

        }
    }
}
