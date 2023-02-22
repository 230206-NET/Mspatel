using Models;
using System.Data.SqlClient;

namespace DataAccess;

// ADO.NET
/*
ADO.NET is a collection of tools and types for accessing databases in uniform fashion
They offer different types to handle different db's but they all inherit from the same supertype, which makes the usage about the same
*/
// To set up,
// make sure you have System.Data.SqlClient package installed on DataAccess project
// and include System.Data.SqlClient namespace

/*
Reading/writing to DB
1. Connect to DB
2. Assemble/Write the query
3. Execute it
4. Process the data or check that it's been successful
*/

public class DBRepository : IRepository
{

    /// <summary>
    /// Retrieves all workout sessions
    /// </summary>
    /// <returns>a list of workout sessions</returns>
    public List<User> GetAllUser()
    {
        // List<User> alluser = new();
        // // Equivalent to opening Azure Data Studio and filling out the new connection form
        // SqlConnection connection = new SqlConnection(hide.getdbConnection()); 

        // // Click the "Connect" button
        // connection.Open();

        // SqlCommand cmd = new SqlCommand("SELECT * FROM UserAccount", connection);
        // SqlDataReader reader = cmd.ExecuteReader();

        // while(reader.Read()) {
        //     alluser.Add(new User {
        //         Id = (int) reader["Id"],
        //         WorkoutDate = (DateTime) reader["WorkoutDate"],
        //         WorkoutName = (string) reader["WorkoutName"],
        //     });
        // }

        // return alluser;
         throw new NotImplementedException();
    }

    /// <summary>
    /// Persists a new workout session to storage
    /// </summary>
    public void CreateNewUser(User sessionToCreate)
    {
        throw new NotImplementedException();
    }

    public List<TicketSession> GetAllTicket() 
    {
         throw new NotImplementedException();
    }
    public void CreateNewSession(TicketSession sessionToCreate) 
    {
        throw new NotImplementedException();
    }   

    public void createUserinDB(User user){throw new NotImplementedException();}
    public User getUserinDB(string username){throw new NotImplementedException();}
    public void createERTinDB(ERT ert){throw new NotImplementedException();}
}