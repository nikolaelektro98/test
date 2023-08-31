using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KaznaBusiness
    {
        KaznaRepository krep;

        //Konstruktor
        public KaznaBusiness()
        {
            this.krep = new KaznaRepository();
        }

        public List<Kazna> Selektovanje()
        {
            return this.krep.Selektovanje();
        }

        public bool UnosKazni(Kazna k)
        {
            return this.krep.UnosKazni(k);
        }

        public bool UpdejtovanjeKazne(Kazna k)
        {
            return this.krep.UpdejtovanjeKazne(k);
        
        }

        public bool BrisanjeKazne(int id)
        {
            return this.krep.BrisanjeKazne(id);
        }
    }
}
