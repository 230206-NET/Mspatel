namespace Models;
    public class ERT
    {
        public string UserName{ get; set; }
        public DateTime TicketDateTime{ get; set; }
        public string Title{get; set;}
        public string Description{get; set;}
        public decimal Amount {get; set;}
        public string Status {get; set;}

        public ERT(){

        }

        public ERT(string username, DateTime ticketdatetime, string title, string des, decimal amount, string status)
        {
            UserName = username;
            TicketDateTime = ticketdatetime;
            Title = title;
            Description = des;
            Amount = amount;
            Status = status;
        }
    }