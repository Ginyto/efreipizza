namespace Projet
{
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
        public Commis(string name, string firstname, int id) : base(name, firstname, id)
        {

        }

        public override void UpdateUser(string name, string firstname)
        {
            Name = name;
            FirstName = firstname;
        }


    }


    

}