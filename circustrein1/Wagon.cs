using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein1
{
    public class Wagon
    {
        private int Plaatsen = 10;
        public List<Dier> Dieren = new List<Dier>();

        public override string ToString()
        {
            return Dieren.ToString();
        }

        public bool toevoegen(Dier dier)
        {
            if (checkPlek(dier.dierGrootte))
            {
                if (dier.checkCarnivoor())
                {
                    if (checkCarnivoren() == null)
                    {
                        if (checkKleiner(dier.dierGrootte))
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if (checkCarnivoren() == null)
                    {
                        return true;
                    }
                    else
                    {
                        if (dier.checkGroter(checkCarnivoren()))
                        {
                            return true;
                        }
                    }
                }    
            }
            return false;
        }

        public bool checkPlek(Dier.grootte Grootte)
        {
            if (Plaatsen - (int)Grootte < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Dier checkCarnivoren()
        {
            foreach (Dier carnivoor in Dieren)
            {
                if (carnivoor.checkCarnivoor() == true)
                {
                    return carnivoor;
                }
            }
            return null;
        }

        public bool checkKleiner(Dier.grootte Grootte)
        {
            foreach (Dier dier in Dieren)
            {
                if (Grootte >= dier.dierGrootte)
                {
                    return false;
                }
            }
            return true;
        }

        public void insertDier(Dier dier)
        {
            Dieren.Add(dier);
            Plaatsen -= (int)dier.dierGrootte;
        }
    }


}
