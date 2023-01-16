using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Player
    {
        string name;
        string surname;
        ERole role;

        public enum ERole 
        { 
            Rosa,
            Riserva
        }
        public Player(string name, string surname, ERole role)
        {
            name = "nome";
            surname = "cognome";
            ERole eRole = role;
        }

        public string Description()
        {   
            
        }

        public ERole Role { 
            get { return role; }
        }

    }
}