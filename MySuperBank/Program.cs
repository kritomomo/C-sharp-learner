using System;

namespace MySuperBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Robert", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
          //  Console.WriteLine(account.Balance);

            account.MakeDeposit(50, DateTime.Now, "steavean");
           // Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());







            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
