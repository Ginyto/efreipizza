using System;

    public class Deliver : User
    {


        public Deliver(int id, string name, string firstname) : base(id, name, firstname)
        {

        }
        public override void UpdateUser()
        {

        }

        public override void PrintUser()
        {
            Console.WriteLine($"Deliver: {Name} {FirstName} {Id}");
        }

    }
