using Models;
using DataAccess;
using Services;
namespace UI;
public class RegisterPage
{
      private FileStorage file = new FileStorage();
      private string AccountType;
    public RegisterPage(){
        while(true)
        {
            Console.WriteLine("Account Type");
            Console.WriteLine("[1] Create New Employee Account");
            Console.WriteLine("[2] Create New Manager Account");

            string? input = Console.ReadLine();
            Console.WriteLine(input);
            if(input == "1")
            {
                    AccountType = "Employee";
                    break;
            }
            else if(input == "2")
            {
                    AccountType = "Manager";
                    break;
            }
            else{
                Console.WriteLine("I don't understand your input");
            }
        }

        Console.WriteLine("Enter your First Name");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Enter your Last Name");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Enter your Account Username");
        string? username = Console.ReadLine()!;
        while(!checkForSameUsername(username)){
            Console.WriteLine("Username Already Taken: Try Again\n");
            Console.WriteLine("Enter your Account Username");
            username = Console.ReadLine();
        }
        Console.WriteLine("Enter your Account Password");
        string? password = Console.ReadLine()!;
        Console.WriteLine("Creating New Account....");
        file.CreateNewUser(new User(username, password, firstName, lastName, AccountType));
        file.createUserinDB(new User(username, password, firstName, lastName, AccountType));
        Console.WriteLine("Account Created Returning to Front Screen\n");
    }
    public bool checkForSameUsername(string userName)
    {
        List<User> userslist = file.GetAllUser();
        foreach(User user in userslist)
        {
            if (user.UserName == userName)
            {
                return false;
            }
        }
        return true;
    }
}