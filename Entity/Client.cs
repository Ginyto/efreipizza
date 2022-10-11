using System;
    public class Client : User
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Date { get; set; }
        public int Score { get; set; }
        

        public Client(int id, string name, string firstname,string address, string phone) : base(id, firstname, name)
        {
            Address = address;
            Phone = phone;
            Date = DateTime.Now.ToString("dd/MM/yyyy");
            Score = 0;
        }

        public override void UpdateUser()
        {

            PrintUser();
        }

        public override void PrintUser()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("FirstName: " + FirstName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Date: " + Date);
        }

    }



