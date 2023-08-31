using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;
using DataLayer;
using BusinessLayer;

namespace Policijska_Uprava
{
    public partial class usrDosije : UserControl
    {
        Osoba o = new Osoba();
        OsobaRepository obus = new OsobaRepository();
        List<Osoba> listOsoba = new List<Osoba>();
        Kazna k = new Kazna();
        KaznaRepository kbus = new KaznaRepository();
        List<Kazna> listKazna = new List<Kazna>();
        Dosije d = new Dosije();
        DosijeBusiness dbus = new DosijeBusiness();
        int idOsobe;
        int idKazne;
        public usrDosije()
        {
            listOsoba = obus.SelektovanjeLista();
            InitializeComponent();
            pictureBoxChecked.Hide();
            pictureBoxNema.Hide();
            listKazna = kbus.Selektovanje();

            foreach (Kazna k in listKazna)
            {
                comboBoxKazne.Items.Add(k.TipKazne);
            }
        }

        private void textJMBG_Enter(object sender, EventArgs e)
        {
            if (textJMBG.Text == "Unesi JMBG")
            {
                textJMBG.Text = "";
                textJMBG.TextAlign = HorizontalAlignment.Left;

            }
            pictureBoxChecked.Hide();
            pictureBoxNema.Hide();
        }

        private void textDatum_Enter(object sender, EventArgs e)
        {
            if (textDatum.Text == "Unesi Datum")
            {
                textDatum.Text = "";
                textDatum.TextAlign = HorizontalAlignment.Left;
                
            }
        }
        private void textBoxBrojZnacke_Enter(object sender, EventArgs e)
        {
            if (textBoxBrojZnacke.Text == "Unesi Broj Znacke")
            {
                textBoxBrojZnacke.Text = "";
                textBoxBrojZnacke.TextAlign = HorizontalAlignment.Left;
            }

        }
        private void textDatum_Leave(object sender, EventArgs e)
        {
            if (textDatum.Text == "")
            {
                textDatum.Text = "Unesi Datum";
                textDatum.TextAlign = HorizontalAlignment.Center;
            }

            }
        private void textBoxBrojZnacke_Leave(object sender, EventArgs e)
        {
            if (textBoxBrojZnacke.Text == "")
            {
                textBoxBrojZnacke.Text = "Unesi Broj Znacke";
                textBoxBrojZnacke.TextAlign = HorizontalAlignment.Center;
            }

        }

        private void textJMBG_Leave(object sender, EventArgs e)
        {
            if (textJMBG.Text == "")
            {
                textJMBG.Text = "Unesi JMBG";
                textJMBG.TextAlign = HorizontalAlignment.Center;
                pictureBoxNema.Hide();
                pictureBoxChecked.Hide();
            }

           
            foreach (Osoba o1 in listOsoba)
            {
                if(textJMBG.Text == o1.Jmbg)
                {
                    pictureBoxNema.Hide();
                    pictureBoxChecked.Show();
                    textIme.Text = o1.Ime;
                    textPrezime.Text = o1.Prezime;
                    textDatumRodjenja.Text = o1.DatumRodjenja;
                    idOsobe = o1.Id;
                    break;

                }
                else
                {
                    pictureBoxNema.Show();
                    
                    
                }
            }


        }

        private void comboBoxKazne_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Kazna k in listKazna)
            {
                if (k.TipKazne == comboBoxKazne.Text)
                {
                   
                    idKazne = k.Id;
                }

            }
        }

        private void Dosije_Load(object sender, EventArgs e)
        {

        }

        private void butDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                d.IdOsobe = idOsobe;
                d.IdKazne = idKazne;
                d.BrojZnacke = Convert.ToInt32(textBoxBrojZnacke.Text);
                d.Datum = textDatum.Text;
                bool test = dbus.UnosDosijea(d);
                if (test)
                {
                    MessageBox.Show("Uneli ste kaznu u dosije");

                }
                else
                {
                    MessageBox.Show("Uneli ste pogresne podatke");

                }
               
            }
            catch
            {
                MessageBox.Show("Uneli ste pogresne podatke");
            }
        }

        private void butOsvezi_Click(object sender, EventArgs e)
        {
            comboBoxKazne.Items.Clear();
            listOsoba = obus.SelektovanjeLista();
            listKazna = kbus.Selektovanje();

            foreach (Kazna k in listKazna)
            {
                comboBoxKazne.Items.Add(k.TipKazne);
            }
            listKazna = kbus.Selektovanje();
            textDatum.Text = "Unesi Datum";
            textDatum.TextAlign = HorizontalAlignment.Center;
            textBoxBrojZnacke.Text = "Unesi Broj Znacke";
            textBoxBrojZnacke.TextAlign = HorizontalAlignment.Center;
            textJMBG.Text = "Unesi JMBG";
            textJMBG.TextAlign = HorizontalAlignment.Center;
            textIme.Text = "";
            textPrezime.Text = "";
            textDatumRodjenja.Text = "";


        }
    }
}
