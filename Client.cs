<<<<<<< HEAD
class Client {

    public string Name { get; set; }
    public string FirstName { get; set; }
    public int OrderNumber { get; set; }
    public string DateOfFirstCommand { get; set; }



    public Client(string name, string firstname, int ordernumber, string dateoffirstcommand)
=======
namespace Projet {

    public class Client : User
>>>>>>> 8d8eb00f5b39190d45cfe96a5659f926c675c638
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Date { get; set; }
        public int Score { get; set; }
        

        public Client (int id) : base(id){}

        public Client(int id, string name, string firstname,string address, string phone) : base(id, firstname, name)
        {
            Address = address;
            Phone = phone;
            Date = DateTime.Now.ToString("dd/MM/yyyy");
            Score = 0;
        }


        public void CreateUser()
        {
            Score = 0;
            
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();

            Console.WriteLine("Phone: ");
            Phone = Console.ReadLine();

            Date = DateTime.Now.ToString("dd/MM/yyyy");

            if (String.IsNullOrEmpty(Address) || String.IsNullOrEmpty(Phone))
            {
                Console.WriteLine("Error: Please fill all the fields");
            }

        }

        public override void UpdateUser()
        {
            Console.WriteLine("\nYou are updating the user: " + Name + " " + FirstName + "\nPress enter to skip" + "\n");

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            if (!String.IsNullOrEmpty(name)){ Name = name; }

            Console.WriteLine("FirstName: ");
            string firstname = Console.ReadLine();
            if (!String.IsNullOrEmpty(firstname)){ FirstName = firstname; }

            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            if (!String.IsNullOrEmpty(address)){ Address = address; }

            Console.WriteLine("Phone: ");
            string phone = Console.ReadLine();
            if (!String.IsNullOrEmpty(phone)){ Phone = phone; }

            Console.WriteLine("Date de la première commande: ");
            string date = Console.ReadLine();
            if (!String.IsNullOrEmpty(date)){ Date = date; }

            Console.WriteLine("\n***User updated!***\n");

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

<<<<<<< HEAD

=======
>>>>>>> 8d8eb00f5b39190d45cfe96a5659f926c675c638
}

