using Microsoft.VisualStudio.TestTools.UnitTesting;
using circustrein1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein1.Tests
{
    [TestClass()]
    public class TreinTests
    {
        Trein trein;

        [TestInitialize]

        public void TestInitialize()
        {
            trein = new Trein();
        }


        [TestMethod()]
        public void addKleineCarnivoorBijKleineHerbivoorTest()
        {
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.klein));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.klein));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addMediumCarnivoorBijKleineHerbivoorTest()
        { 
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.klein));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.medium));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addGroteCarnivoorBijKleineHerbivoorTest()
        {    
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.klein));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.groot));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addKleineCarnivoorBijMediumHerbivoorTest()
        {    
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.medium));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.klein));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(1, waarde);
        }

        [TestMethod()]
        public void addMediumCarnivoorBijMediumHerbivoorTest()
        {    
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.medium));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.medium));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addGroteCarnivoorBijMediumHerbivoorTest()
        {    
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.medium));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.groot));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addKleineCarnivoorBijGroteHerbivoorTest()
        {    
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.groot));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.klein));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(1, waarde);
        }

        [TestMethod()]
        public void addMediumCarnivoorBijGroteHerbivoorTest()
        {    
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.groot));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.medium));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(1, waarde);
        }

        [TestMethod()]
        public void addGroteCarnivoorBijGroteHerbivoorTest()
        {    
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.groot));
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.groot));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addKleineHerbivoorBijKleineCarnivoorTest()
        {    
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.klein));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.klein));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addMediumHerbivoorBijKleineCarnivoorTest()
        {    
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.klein));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.medium));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(1, waarde);
        }

        [TestMethod()]
        public void addGroteHerbivoorBijKleineCarnivoorTest()
        {
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.klein));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.groot));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(1, waarde);
        }

        [TestMethod()]
        public void addKleineHerbivoorBijMediumCarnivoorTest()
        {
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.medium));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.klein));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addMediumHerbivoorBijMediumCarnivoorTest()
        {
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.medium));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.medium));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addGroteHerbivoorBijMediumCarnivoorTest()
        {
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.medium));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.groot));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(1, waarde);
        }

        [TestMethod()]
        public void addKleineHerbivoorBijGroteCarnivoorTest()
        {
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.groot));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.klein));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addMediumHerbivoorBijGroteCarnivoorTest()
        {
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.groot));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.medium));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void addGroteHerbivoorBijGroteCarnivoorTest()
        { 
            trein.addDier(new Dier("Leeuw", Dier.soort.Carnivoor, Dier.grootte.groot));
            trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.groot));
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void add11KleineDierenTest()
        {
            for (int i = 0; i < 11; i++)
            {
                trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.klein));
            }
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void add4MediumDierenTest()
        {
            for (int i = 0; i < 4; i++)
            {
                trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.medium));
            }
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }

        [TestMethod()]
        public void add3GroteDierenTest()
        {
            for (int i = 0; i < 3; i++)
            {
                trein.addDier(new Dier("Aap", Dier.soort.Herbivoor, Dier.grootte.groot));
            }
            int waarde = trein.Wagons.Count;

            Assert.AreEqual(2, waarde);
        }
    }
}