using System;

    /// <summary>
    /// Commis capable de prendre de gerer la pizzaria entiere
    /// </summary>
    public class Commis : User
    {
        /// <summary>
        /// Constructeur du commis
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="firstname">Prenom</param>
        /// <returns>Un commis</returns>


        public Commis(int id, string name, string firstname) : base(id, name, firstname)
        {

        }

        public override void UpdateUser()
        {

        }


        public override void PrintUser()
        {
            Console.WriteLine($"Commis: {Name} {FirstName} {Id}");
        }


    }


    

