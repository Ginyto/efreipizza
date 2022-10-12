using System;
    public abstract class User
    {
    public string Name { get; set; } = "";
    public string FirstName { get; set; } = "";
    public int Id { get; set; }

        public User (int id, string name, string firstname)
        {
            Name = name;
            FirstName = firstname;
            Id = id;
        }

        public User(){}

        public abstract void PrintUser();
        public abstract void UpdateUser();


    }

