using Models;
using DataAccess;
using Services;
namespace UI;
public class ManagerPortal
{
    public ManagerPortal(User user)
    {
         Console.WriteLine("User: {0} Has Logged In", user.UserName);
         Console.WriteLine("Welcome {0} {1} To Manager Portal", user.FirstName, user.LastName);
        while(true)
        {
            Console.WriteLine("Select One?");
            Console.WriteLine("[1] Approve/Reject Pending Ticket");
            Console.WriteLine("[1] View All Tickets");
            Console.WriteLine("[x] Logout");
            
            string? input = Console.ReadLine();
            if(input == "1"){
                // Portal to Manager Interaction with ticket
                break;
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
}