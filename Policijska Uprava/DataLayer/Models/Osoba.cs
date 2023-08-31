using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Osoba
    {
        private int id;
        private string ime;
        private string prezime;
        private string jmbg;
        private string pol;
        private string datumRodjenja;
        private int dozvola;

        public Osoba()
        {
        }

        public Osoba(string ime, string prezime, string jmbg, string pol, string datumRodjenja, int dozvola)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.pol = pol;
            this.datumRodjenja = datumRodjenja;
            this.dozvola = dozvola;
        }

        public Osoba(int id, string ime, string prezime, string jmbg, string pol, string datumRodjenja, int dozvola)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.pol = pol;
            this.datumRodjenja = datumRodjenja;
            this.dozvola = dozvola;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Pol { get => pol; set => pol = value; }
        public int Dozvola { get => dozvola; set => dozvola = value; }
        public string DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
    }
}
