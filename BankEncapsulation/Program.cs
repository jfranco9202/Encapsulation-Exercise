using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_Account ba = new Bank_Account();
            
            Console.WriteLine($"How much money would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());
            
            ba.Deposit(amountToDeposit);
            double UserBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is {UserBalance,0:C}");


        }
    }
}
