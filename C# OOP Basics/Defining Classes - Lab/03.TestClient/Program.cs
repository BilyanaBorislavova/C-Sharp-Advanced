using System;
using System.Collections.Generic;

namespace BankAccount
{
   public class Program
    {
       public  static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<int, BankAccount> dict = new Dictionary<int, BankAccount>();

            while (command != "End")
            {
                string[] cmdInfo = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = cmdInfo[0];
                int id = int.Parse(cmdInfo[1]);

                if (currentCommand == "Create")
                {
                    if(!dict.ContainsKey(id))
                    {
                        var bankAccount = new BankAccount();
                        bankAccount.Id = id;
                        dict.Add(id, bankAccount);
                    }
                    else
                    {
                        Console.WriteLine("Account already exists");
                    }
                }
                else if(currentCommand == "Deposit")
                {
                    int amount = int.Parse(cmdInfo[2]);

                    if(!dict.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        dict[id].Deposit(amount);
                    }
                }
                else if(currentCommand == "Withdraw")
                {
                    int amount = int.Parse(cmdInfo[2]);

                    if (!dict.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        dict[id].Withdraw(amount);
                    }

                }
                else if(currentCommand == "Print")
                {
                    if (!dict.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        Console.WriteLine(dict[id].ToString());
                    }
                }


                command = Console.ReadLine();
            }

        }
    }
}
