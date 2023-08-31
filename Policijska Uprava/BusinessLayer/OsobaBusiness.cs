using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OsobaBusiness
    {
        OsobaRepository orep;

        public OsobaBusiness()
        {
            this.orep = new OsobaRepository();
        }

        public List<Osoba> SelektovanjeLista()
        {
            return this.orep.SelektovanjeLista();
        }

        public DataTable Selektovanje()
        {
            return this.orep.Selektovanje();
        }

        public bool UnosOsoba(Osoba o)
        {
            return this.orep.UnosOsoba(o);
        }
        public bool BrisanjeOsoba(string jmbg)
        {
            return this.orep.BrisanjeOsoba(jmbg);
        }
    }
}
