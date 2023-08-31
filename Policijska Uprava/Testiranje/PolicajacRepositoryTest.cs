using DataLayer;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testiranje
{
    [TestClass]
    public class PolicajacRepositoryTest
    {

        Policajac policajac;
        PolicajacRepository policajacRep;
        List<Policajac> listPolicajac = new List<Policajac>();

        [TestInitialize]
        public void Init()
        {
            policajacRep = new PolicajacRepository();
            policajac = new Policajac(1234,"Ime","Prezime","1231231231231","muski","22/12/1998");
        }

        [TestMethod]
        public void TestUnosKazne()
        {

            policajacRep.UnosPolicajaca(policajac);
            listPolicajac = policajacRep.SelektovanjeLista();

            foreach (Policajac p in listPolicajac)
            {

                if (p.BrojZnacke == policajac.BrojZnacke)
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
        }
    }
}
