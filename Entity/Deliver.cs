

    public class Deliver : User
    {


        public Deliver(int id) : base(id)
        {

        }
        public override void UpdateUser()
        {

        }

        public override string PrintUser()
        {
            return $"Deliver: {Name} {FirstName} {Id}";
        }

    }

