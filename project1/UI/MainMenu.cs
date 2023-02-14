using Login;
namespace UI;
    public class MainMenu
    {
        public void Start()
        {
            LoginInfo log = new LoginInfo();

            Console.WriteLine("Username: ");
            string user = Console.ReadLine();
            Console.WriteLine("Password: ");
            string pass = Console.ReadLine();

            log.Username = user;
            log.Password = pass;

            Console.WriteLine("User : " + user);
            Console.WriteLine("Username : " + log.Username);

            Console.WriteLine("Pass : " + pass);
            Console.WriteLine("Password : " + log.Password);
        }
    }
