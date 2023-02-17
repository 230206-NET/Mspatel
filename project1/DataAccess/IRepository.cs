using Models;

public interface IRepository
{
    /// <summary>
    /// Retrieves all ticket sessions
    /// </summary>
    /// <returns>a list of ticket sessions</returns>
    List<TicketSession> GetAllTicket();

    /// <summary>
    /// Persists a new ticket session to storage
    /// </summary>
    void CreateNewSession(TicketSession sessionToCreate);
}