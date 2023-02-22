namespace DataAccess;
    internal class hide
    {
        private const string _connectionsqldb = "Server=tcp:workoutdb-server.database.windows.net,1433;Initial Catalog=workoutDBSQL;Persist Security Info=False;User ID=workoutdb;Password=workout@12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static string getdbConnection() => _connectionsqldb;
    }