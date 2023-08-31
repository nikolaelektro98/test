using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DosijeBusiness
    {
        DosijeRepository drep;

        //Konstruktor
        public DosijeBusiness()
        {
            this.drep = new DosijeRepository();
        }

        public List<Dosije> Selektovanje()
        {
            return this.drep.Selektovanje();
        }
        public bool UnosDosijea(Dosije d)
        {
            return this.drep.UnosDosijea(d);
        }

        }
}
