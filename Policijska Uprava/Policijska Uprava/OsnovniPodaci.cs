using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Models;
using DataLayer;

namespace Policijska_Uprava
{
    public partial class OsnovniPodaci : UserControl
    {
        public string jmbg;
        Osoba o = new Osoba();
        OsobaRepository obus = new OsobaRepository();
        List<Osoba> listOsoba = new List<Osoba>();
        Kazna k = new Kazna();
        KaznaRepository kbus = new KaznaRepository();
        List<Kazna> listKazna = new List<Kazna>();
        Dosije d = new Dosije();
        DosijeBusiness dbus = new DosijeBusiness();
        List<Dosije> listDosije = new List<Dosije>();
        int idOsobe;

        public OsnovniPodaci()
        {
            InitializeComponent();
            listOsoba = obus.SelektovanjeLista();
            listKazna = kbus.Selektovanje();
            listDosije = dbus.Selektovanje();

        }
        public void Dodela(string myString)
        {
            jmbg = myString;
            textJMBG.Text = jmbg;
            listOsoba = obus.SelektovanjeLista();
            listKazna = kbus.Selektovanje();
            listDosije = dbus.Selektovanje();
            foreach (Osoba o1 in listOsoba)
            {
                if (textJMBG.Text == o1.Jmbg)
                {

                    textIme.Text = o1.Ime;
                    textPrezime.Text = o1.Prezime;
                    textDatumRodjenja.Text = o1.DatumRodjenja;
                    textPol.Text = o1.Pol;
                    idOsobe = o1.Id;

                }
            }
            int i = 0;

            foreach (Dosije d1 in listDosije)
            {
                if (idOsobe == d1.IdOsobe)
                {
                    foreach (Kazna k1 in listKazna)
                    {

                        if (d1.IdKazne == k1.Id)
                        {
                            comboBoxKazne.Items.Add(k1.TipKazne);
                        }
                    }
                }
            }
        }
        private void OsnovniPodaci_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxKazne_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Kazna k in listKazna)
            {
                if (k.TipKazne == comboBoxKazne.Text)
                {

                    textIznos.Text = k.Iznos.ToString();
                    textZatvor.Text = k.Zatvor.ToString();
                    textPoene.Text = k.Poeni.ToString();

                }
            }
        }
    }
}
