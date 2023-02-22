using Models;
using DataAccess;
using Services;
namespace UI;
public class LoginPage
{
    private FileStorage file = new FileStorage();
    private string AccountType;

    public List<User> currentuser = new();
    public LoginPage(){
        while(true)
        {
            Console.WriteLine("Account Type");
            Console.WriteLine("[1] Login For Employee Account");
            Console.WriteLine("[2] Login For Manager Account");

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

        Console.WriteLine("Enter your Username: ");
        string? username = Console.ReadLine();
        Console.WriteLine("Enter your Password: ");
        string? password = Console.ReadLine();
        Console.WriteLine("Matching Login Information....");
        bool userin = UserCredSame(username, password, AccountType);
        if(userin == true) 
        {
            Console.WriteLine("Login and Test Worked");
        }
        if(userin == false)
        {
            Console.WriteLine("No Account Found Matching this Username");
        }
    }

    private bool UserCredSame(string usname, string pass, string postitiontype)
    {
        List<User> loglist = file.GetAllUser();
        bool status = false;
        foreach(User acc in loglist)
        {
            if(usname == acc.UserName && pass == acc.Password && postitiontype == acc.Position && postitiontype == "Employee")
            {
                status = true;
                User user = file.getUserinDB(usname);
                Console.WriteLine("Employee Logged In");
                // move to employee portal
                new EmployeePortal(user);
                Console.WriteLine("Employee Logged Out");
                break;
            } 
            else if(usname == acc.UserName && pass == acc.Password && postitiontype == acc.Position && postitiontype == "Manager")
            {
                status = true;
                User user = file.getUserinDB(usname);
                Console.WriteLine("Manager Logged In");
                // move ot manager portal
                new ManagerPortal(user);
                Console.WriteLine("Manager Logged Out");
                break;
            }                 
        }
        return status;
    }
}