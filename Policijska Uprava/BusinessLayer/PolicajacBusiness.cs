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
    public class PolicajacBusiness
    {
        PolicajacRepository prep;

        public PolicajacBusiness()
        {
            this.prep = new PolicajacRepository();
        }

        public List<Policajac> SelektovanjeLista()
        {
            return this.prep.SelektovanjeLista();
        }
        public DataTable Selektovanje()
        {
            return this.prep.Selektovanje();

        }
        public bool UnosPolicajaca(Policajac p)
        {
            return this.prep.UnosPolicajaca(p);
        }

        public bool BrisanjePolicajaca(string jmbg)
        {
            return this.prep.BrisanjePolicajaca(jmbg);
        }
    }
}
