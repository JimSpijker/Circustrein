using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein1
{
    public class Dier
    {
        
        public enum soort
        {
            Herbivoor,
            Carnivoor
        }
        public enum grootte
        {
            klein = 1,
            medium = 3,
            groot = 5
        }

        public soort dierSoort;
        public grootte dierGrootte; //1, 3 of 5
        public string naam;

        //Constructor
        public Dier(string Naam, soort Soort, grootte Grootte)
        {
            dierSoort = Soort;
            dierGrootte = Grootte;
            naam = Naam;
        }

        //Methods
        public override string ToString()
        {
            return(naam + " " + dierSoort + " " + dierGrootte);
        }

        public bool checkCarnivoor()
        {
            if (dierSoort == soort.Carnivoor)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool checkGroter(Dier vleeseter)
        {
            if (dierGrootte > vleeseter.dierGrootte)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
