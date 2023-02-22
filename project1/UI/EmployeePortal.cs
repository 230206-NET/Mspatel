using Models;
using DataAccess;
using Services;
namespace UI;
public class EmployeePortal
{
    private FileStorage file = new FileStorage();
    public EmployeePortal(User user)
    {
        Console.WriteLine();
        Console.WriteLine("User: {0} Has Logged In", user.UserName);
        Console.WriteLine("Welcome {0} {1} To Employee Portal", user.FirstName, user.LastName);
        Console.WriteLine();

        while(true)
        {
            Console.WriteLine("Select One?");
            Console.WriteLine("[1] Submit New Ticket");
            Console.WriteLine("[2] View All Submitted Tickets");
            Console.WriteLine("[x] Logout");
            
            string? input = Console.ReadLine();
            if(input == "1"){
                // create new ticket to submitt
                DateTime dt = DateTime.Now;
                string status = "Pending";
                submitTicket(user.UserName, dt, status);
                //break;
            }
            else if(input == "2")
            {
                    // view all tickets submitted from employee
                    getAllEmployeeTickets(user.UserName);
                    //break;
            }
            else if(input == "x")
            {
                break;
            }
            else {
                Console.WriteLine("I Don't understand your input");
            }
        }    
    }

    private void submitTicket(string username, DateTime dts, string currentstatus)
    {
        Console.WriteLine();
        Console.WriteLine("Enter Ticket Title (ex.Plane Travel): ");
        string? title = Console.ReadLine();
        Console.WriteLine("Enter Ticket Description: ");
        string? des = Console.ReadLine();
        Console.WriteLine("Enter Amount: ");
        decimal amount = 0;
        decimal.TryParse(Console.ReadLine(), out amount);
        //Console.WriteLine(amount);
        Console.WriteLine("Submitting Ticket From User...");
        file.createERTinDB(new ERT(username, dts, title, des, amount, currentstatus));
        Console.WriteLine("Submit Processed");
        Console.WriteLine();
    }

    private void getAllEmployeeTickets(string username)
    {
        Console.WriteLine("Retrieving Employee {0} Submitted Tickets", username);
        List<ERT> list = new();
        file.GetAllTicketsByUsername(username, list);
        foreach(ERT ert in list){
            Console.WriteLine();
            Console.WriteLine(ert.ToString());
            Console.WriteLine();
        }
    }
}