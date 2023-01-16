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
            // TODO P.1
        }

        public string Description()
        {
            // TODO P.2
        }

        public ERole Role { 
            // TODO P.3
        }

    }
}