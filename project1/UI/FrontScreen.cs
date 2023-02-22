using DataAccess;
using System;
namespace UI;
public class FrontScreen
{
    public void Start()
    {
        while(true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Expense Reimbursement System Application");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] Login to ERS Account");
            Console.WriteLine("[2] Register a New ERS Account");
            Console.WriteLine("[x] Exit Application\n");

            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    // move to login page
                    new LoginPage();
                break;
                case "2":
                    // move to register page for users
                    new RegisterPage();
                break;
                case "x":
                    // exit and terminate code 
                    Environment.Exit(0);
                break;
                default:
                    // anything else then print this message and restart while looping until 1 of 3 is cases is hit
                    Console.WriteLine("I don't understand your input");
                break;
            }
        }
    }
}