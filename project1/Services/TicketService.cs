using Models;

namespace Services;
    public class TicketService
    {
        // Dependency Injection: is a design pattern where the dependency of a class is injected through the constructor instead of the class itself having a specific knowledge of its dependency, or instantiating itself
        // This example here is actually a combination of dependency injection and dependency inversion
        // This allows for more flexible change in implementation, also this pattern makes unit testing much simpler
        private readonly IRepository _repo;
        public TicketService(IRepository repo) {
            _repo = repo;
        }

        public List<TicketSession> GetAllTicket() 
        {
            return _repo.GetAllTicket();
        }

        // An example of business logic that is not UI or data access
        public List<TicketSession> SearchTicketsByName(string searchTerm) {
            List<TicketSession> allSessions = GetAllTicket();
            List<TicketSession> filtered = new();
            foreach(TicketSession s in allSessions) {
                foreach(Ticket ex in s.TicketForm) {
                    if(ex.TicketName.Contains(searchTerm)) {
                        filtered.Add(s);
                        break;
                    }
                }
            }

            return filtered;
        }
        public void CreateNewSession(TicketSession sessionToCreate) 
        {
            _repo.CreateNewSession(sessionToCreate);
        }
    }
