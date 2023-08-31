using DataLayer;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testiranje
{
    [TestClass]
    public class DosijeRepositryTest
    {

        Dosije dosije;
        Policajac policajac;
        Osoba osoba;
        Kazna kazna;

        DosijeRepository dosijeRep;
        PolicajacRepository policajacRep;
        OsobaRepository osobaRep;
        KaznaRepository kaznaRep;

        List<Osoba> listOsobe = new List<Osoba>();
        List<Policajac> listPolicajac = new List<Policajac>();
        List<Kazna> listKazna = new List<Kazna>();
        List<Dosije> listDosije = new List<Dosije>();

        [TestInitialize]
        public void Init(){

            policajac = new Policajac(1234, "Ime", "Prezime", "1231231231231", "muski", "22/12/1998");
            osoba = new Osoba("Ime", "Prezime", "1234512345123", "Muski", "22/12/1998", 1);
            kazna = new Kazna("Test", 100, 100, 100);

            policajacRep = new PolicajacRepository();
            osobaRep = new OsobaRepository();
            kaznaRep = new KaznaRepository();
            dosijeRep = new DosijeRepository();


            osobaRep.UnosOsoba(osoba);
            listOsobe = osobaRep.SelektovanjeLista();
            policajacRep.UnosPolicajaca(policajac);
            listPolicajac = policajacRep.SelektovanjeLista();
            kaznaRep.UnosKazni(kazna);
            listKazna = kaznaRep.Selektovanje();

            foreach (Osoba o in listOsobe)
            {
                if (o.Ime.Equals(osoba.Ime) && o.Prezime.Equals(osoba.Prezime) && o.Jmbg.Equals(osoba.Jmbg) && o.Pol.Equals(osoba.Pol) && o.DatumRodjenja.Equals(osoba.DatumRodjenja))
                {
                    osoba.Id = o.Id;
                }
            }

            foreach (Kazna k in listKazna)
            {
                if (k.TipKazne.Equals(kazna.TipKazne) && k.Iznos.Equals(k.Iznos) && k.Poeni.Equals(k.Poeni) && k.Zatvor.Equals(k.Zatvor))
                {
                    kazna.Id = k.Id;
                }
            }

            dosije = new Dosije(osoba.Id,kazna.Id,policajac.BrojZnacke,"5/7/2021");
        }

        [TestMethod]
        public void TestUnosDosijea()
        {

            dosijeRep.UnosDosijea(dosije);
            listDosije = dosijeRep.Selektovanje();

            foreach (Dosije d in listDosije)
            {

                if (d.BrojZnacke == policajac.BrojZnacke && d.IdKazne.Equals(kazna.Id) && d.IdOsobe.Equals(osoba.Id) && d.Datum.Equals(dosije.Datum))
                {
                    return;
                }
            }

            Assert.Fail();
        }

        [TestCleanup]
        public void Cleanup()
        {
            policajacRep.BrisanjePolicajaca(policajac.Jmbg);
            osobaRep.BrisanjeOsoba(osoba.Jmbg);
            kaznaRep.BrisanjeKazne(kazna.Id);
        }
    }
}
