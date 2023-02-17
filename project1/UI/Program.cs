using UI;
using Services;
using DataAccess;

//new MainMenu().Start();

// How to inject dependencies upon instantiation
// new MainMenu(new WorkoutService(new FileStorage())).Start();

IRepository repo = new FileStorage();
TicketService service = new TicketService(repo);
MainMenu menu = new MainMenu(service);
menu.Start();
