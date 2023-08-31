
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Testiranje
{
    [TestClass]
    public class KaznaRepositoryTest
    {

        Kazna kazna;
        KaznaRepository kaznaRep;
        List<Kazna> listKazna = new List<Kazna>();


        [TestInitialize]
        public void Init()
        {
            kaznaRep = new KaznaRepository();
            kazna = new Kazna("Test",100,100,100);
      
            kaznaRep.UnosKazni(kazna);
            listKazna = kaznaRep.Selektovanje();

            foreach (Kazna k in listKazna)
            {
                if (k.TipKazne.Equals(kazna.TipKazne) && k.Iznos.Equals(k.Iznos) && k.Poeni.Equals(k.Poeni) && k.Zatvor.Equals(k.Zatvor))
                {
                    kazna.Id = k.Id;
                    return;
                }
            }
        }

        [TestMethod]
        public void TestUnosKazne()
        {
            
            foreach (Kazna k in listKazna)
            {
                if (k.Id == kazna.Id)
                {
                    return;
                }
            }

            Assert.Fail();
        }

        [TestMethod]
        public void UpdejtovanjeKazne()
        {
            kazna.TipKazne = "NoviTip";
            kaznaRep.UpdejtovanjeKazne(kazna);
            listKazna = kaznaRep.Selektovanje();

            foreach (Kazna k in listKazna)
            {
                if (k.Id == kazna.Id)
                {
                  Assert.AreEqual(kazna.TipKazne, k.TipKazne);
                    return;

                }
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            kaznaRep.BrisanjeKazne(kazna.Id);
        }
    }
}
