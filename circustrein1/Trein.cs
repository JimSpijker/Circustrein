using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein1
{
    public class Trein
    {
        public List<Wagon> Wagons = new List<Wagon>();
        Wagon wagon = new Wagon();

        public bool addDier(Dier dier)
        {
            if (Wagons.Count == 0)
            {
                Wagons.Add(wagon);
            }
            for (int index = 0; index < Wagons.Count(); index++)
            {

                if (Wagons[index].toevoegen(dier))
                {
                    Wagons[index].insertDier(dier);
                    return true;
                }
                else
                {
                    if (Wagons.Count == index + 1)
                    {
                        Wagon wagon = new Wagon();
                        Wagons.Add(wagon);
                    }
                    
                }
            }
            return false;
        }
    }
}
