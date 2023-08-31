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
using BusinessLayer;

namespace Policijska_Uprava
{
    public partial class usrPolicajac : UserControl
    {
        Policajac p = new Policajac();
        PolicajacBusiness pbus = new PolicajacBusiness();

        public usrPolicajac()
        {
            InitializeComponent();
            DataTable dt = pbus.Selektovanje();
            dataGridViewPolicija.DataSource = dt;
        }

        private void textBoxBrojZnacke_Enter(object sender, EventArgs e)
        {
            if (textBoxBrojZnacke.Text == "Unesi Broj Znacke")
            {
                textBoxBrojZnacke.Text = "";
                textBoxBrojZnacke.TextAlign = HorizontalAlignment.Left;
            }

        }

        private void textIme_Enter(object sender, EventArgs e)
        {
            if (textIme.Text == "Unesi Ime")
            {
                textIme.Text = "";
                textIme.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textPrezime_Enter(object sender, EventArgs e)
        {
            if (textPrezime.Text == "Unesi Prezime")
            {
                textPrezime.Text = "";
                textPrezime.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textJMBG_Enter(object sender, EventArgs e)
        {
            if (textJMBG.Text == "Unesi JMBG")
            {
                textJMBG.Text = "";
                textJMBG.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textPol_Enter(object sender, EventArgs e)
        {


            if (textPol.Text == "Unesi Pol")
            {
                textPol.Text = "";
                textPol.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textDatumRodjenja_Enter(object sender, EventArgs e)
        {
            if (textDatumRodjenja.Text == "Unesi Datum Rodjenja")
            {
                textDatumRodjenja.Text = "";
                textDatumRodjenja.TextAlign = HorizontalAlignment.Left;
            }
        }

        // LEAVE 
        private void textBoxBrojZnacke_Leave(object sender, EventArgs e)
        {
            if (textBoxBrojZnacke.Text == "")
            {
                textBoxBrojZnacke.Text = "Unesi Broj Znacke";
                textBoxBrojZnacke.TextAlign = HorizontalAlignment.Center;
            }

        }

        private void textIme_Leave(object sender, EventArgs e)
        {
            if (textIme.Text == "")
            {
                textIme.Text = "Unesi Ime";
                textIme.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textPrezime_Leave(object sender, EventArgs e)
        {
            if (textPrezime.Text == "")
            {
                textPrezime.Text = "Unesi Prezime";
                textPrezime.TextAlign = HorizontalAlignment.Center;
            }

        }

        private void textJMBG_Leave(object sender, EventArgs e)
        {
            if (textJMBG.Text == "")
            {
                textJMBG.Text = "Unesi JMBG";
                textJMBG.TextAlign = HorizontalAlignment.Center;
            }

        }

        private void textPol_Leave(object sender, EventArgs e)
        {
            if (textPol.Text == "")
            {
                textPol.Text = "Unesi Pol";
                textPol.TextAlign = HorizontalAlignment.Center;
            }

        }

        private void textDatumRodjenja_Leave(object sender, EventArgs e)
        {
            if (textDatumRodjenja.Text == "")
            {
                textDatumRodjenja.Text = "Unesi Datum Rodjenja";
                textDatumRodjenja.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void butDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                p.BrojZnacke = Convert.ToInt32(textBoxBrojZnacke.Text);
            }
            catch
            {
                MessageBox.Show("Broj znacke mora biti broj");
            }
            p.Ime = textIme.Text;
            p.Prezime = textPrezime.Text;
            p.Jmbg = textJMBG.Text;
            p.Pol = textPol.Text;
            p.DatumRodjenja = textDatumRodjenja.Text;
            bool status = pbus.UnosPolicajaca(p);
            if (status)
            {
                MessageBox.Show("Uspesno ste uneli policajca");
                DataTable dt = pbus.Selektovanje();
                dataGridViewPolicija.DataSource = dt;
                Osvezi();
            }
            else
            {
                MessageBox.Show("Neuspesno ste uneli policajca");
                Osvezi();
            }

        }

        private void butIzbrisi_Click(object sender, EventArgs e)
        {
            bool status = pbus.BrisanjePolicajaca(textJMBG.Text);
            if (status)
            {
                MessageBox.Show("Uspesno obrisan policajac");
                DataTable dt = pbus.Selektovanje();
                dataGridViewPolicija.DataSource = dt;
                Osvezi();
            }
            else
            {
                MessageBox.Show("Doslo je do greske");

            }
        }
        private void Osvezi()
        {
            textBoxBrojZnacke.Text = "Unesi Broj Znacke";
            textBoxBrojZnacke.TextAlign = HorizontalAlignment.Center;
            textIme.Text = "Unesi Ime";
            textIme.TextAlign = HorizontalAlignment.Center;
            textPrezime.Text = "Unesi Prezime";
            textPrezime.TextAlign = HorizontalAlignment.Center;
            textJMBG.Text = "Unesi JMBG";
            textJMBG.TextAlign = HorizontalAlignment.Center;
            textPol.Text = "Unesi Pol";
            textPol.TextAlign = HorizontalAlignment.Center;
            textDatumRodjenja.Text = "Unesi Datum Rodjenja";
            textDatumRodjenja.TextAlign = HorizontalAlignment.Center;
        }
    }
}
