using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Kazna
    {
        private int id;
        private string tipKazne;
        private int iznos;
        private int zatvor;
        private int poeni;

        public Kazna()
        {
        }

        public Kazna(string tipKazne, int iznos, int zatvor, int poeni)
        {
            this.tipKazne = tipKazne;
            this.iznos = iznos;
            this.zatvor = zatvor;
            this.poeni = poeni;
        }

        public Kazna(int id, string tipKazne, int iznos, int zatvor, int poeni)
        {
            this.id = id;
            this.tipKazne = tipKazne;
            this.iznos = iznos;
            this.zatvor = zatvor;
            this.poeni = poeni;
        }

        public int Id { get => id; set => id = value; }
        public string TipKazne { get => tipKazne; set => tipKazne = value; }
        public int Iznos { get => iznos; set => iznos = value; }
        public int Zatvor { get => zatvor; set => zatvor = value; }
        public int Poeni { get => poeni; set => poeni = value; }
    }
}
