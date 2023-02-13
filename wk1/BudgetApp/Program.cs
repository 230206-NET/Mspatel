using System;
namespace BudgetApp
{
    public class BA
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BudgetApp Start");

            Console.WriteLine("Enter Your Starting Balance");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Starting Balance is: $" + balance);
            while(true)
            {
                Console.WriteLine("Amount of Expense: ");
                int expense = 0;
                int tempExpense = int.Parse(Console.ReadLine());
                if(tempExpense > balance)
                {
                    Console.WriteLine("Expense s greater then Account Balance and Can't be Accepted");
                }
                else
                {
                    expense = tempExpense;
                    balance = balance - expense;
                    Console.WriteLine(balance);
                }
                Console.WriteLine("Are There More Expenses? [y/n]");
                string response = Console.ReadLine();
                if(response == "n")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Account Balance: $" + balance);

        }
    }
}

