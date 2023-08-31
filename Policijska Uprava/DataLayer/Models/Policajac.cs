using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Policajac
    {
        private int brojZnacke;
        private string ime;
        private string prezime;
        private string jmbg;
        private string pol;
        private string datumRodjenja;

        public Policajac()
        {
            
        }

        public Policajac(int brojZnacke, string ime, string prezime, string jmbg, string pol, string datumRodjenja)
        {
            this.brojZnacke = brojZnacke;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.pol = pol;
            this.datumRodjenja = datumRodjenja;
        }

        public int BrojZnacke { get => brojZnacke; set => brojZnacke = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Pol { get => pol; set => pol = value; }
        public string DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
    }
}
