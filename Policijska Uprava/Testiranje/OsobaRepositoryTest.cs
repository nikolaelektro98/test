using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
using DataLayer;

namespace Testiranje
{
    [TestClass]
   public class OsobaRepositoryTest
    {

        Osoba osoba;
        OsobaRepository osobaRep;
        List<Osoba> listOsobe = new List<Osoba>();

        [TestInitialize]
        public void Init()
        {
            osobaRep = new OsobaRepository();
            osoba = new Osoba("Ime","Prezime","1234512345123","Muski","22/12/1998",1);

            osobaRep.UnosOsoba(osoba);
            listOsobe = osobaRep.SelektovanjeLista();

            foreach (Osoba o in listOsobe)
            {
                if (o.Ime.Equals(osoba.Ime) && o.Prezime.Equals(osoba.Prezime) && o.Jmbg.Equals(osoba.Jmbg) && o.Pol.Equals(osoba.Pol) && o.DatumRodjenja.Equals(osoba.DatumRodjenja))
                {
                    osoba.Id = o.Id;
                    return;
                }
            }

        }

        [TestMethod]
        public void TestUnosOsoba()
        {

            foreach (Osoba o in listOsobe)
            {
                if (o.Id == osoba.Id)
                {
                    return;
                }
            }

            Assert.Fail();
        }

        [TestCleanup]
        public void Cleanup()
        {
            osobaRep.BrisanjeOsoba(osoba.Jmbg);
        }
    }
}
