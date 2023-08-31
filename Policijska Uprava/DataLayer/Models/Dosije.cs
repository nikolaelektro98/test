using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Dosije
    {
        private int id;
        private int idOsobe;
        private int idKazne;
        private int brojZnacke;
        private string datum;

        public Dosije()
        {
        }

        public Dosije(int idOsobe, int idKazne, int brojZnacke, string datum)
        {
            this.idOsobe = idOsobe;
            this.idKazne = idKazne;
            this.brojZnacke = brojZnacke;
            this.datum = datum;
        }

        public int Id { get => id; set => id = value; }
        public int IdOsobe { get => idOsobe; set => idOsobe = value; }
        public int IdKazne { get => idKazne; set => idKazne = value; }
        public int BrojZnacke { get => brojZnacke; set => brojZnacke = value; }
        public string Datum { get => datum; set => datum = value; }
    }
}
