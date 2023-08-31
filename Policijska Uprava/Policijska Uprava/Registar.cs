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
    public partial class Registar : UserControl
    {
        Osoba o = new Osoba();
        OsobaBusiness obus = new OsobaBusiness();
        public Registar()
        {
            InitializeComponent();
            pictureBoxChecked.Hide();
            DataTable dt = obus.Selektovanje();
            dataGridViewOsobe.DataSource = dt;

        }

        /*  ENTER */
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

            /*  Leave */
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

            private void checkBoxIma_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBoxIma.Checked)
                {
                    pictureBoxChecked.Show();
                    pictureBoxNema.Hide();
                }
                else
                {
                    pictureBoxNema.Show();
                    pictureBoxChecked.Hide();
                }
            }

            private void Registar_Load(object sender, EventArgs e)
            {

            }

        private void butDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                o.Ime = textIme.Text;
                o.Prezime = textPrezime.Text;
                o.Jmbg = textJMBG.Text;
                o.Pol = textPol.Text;
                o.DatumRodjenja = textDatumRodjenja.Text;
                if (checkBoxIma.Checked)
                {
                    o.Dozvola = 1;
                }
                else
                {
                    o.Dozvola = 0;
                }
                bool status = obus.UnosOsoba(o);
                if (status)
                {
                    MessageBox.Show("Uspesno ste uneli osobu");
                    DataTable dt = obus.Selektovanje();
                    dataGridViewOsobe.DataSource = dt;
                    Osvezi();
                }
                else
                {
                    MessageBox.Show("Neuspesno ste uneli osobu");
                    Osvezi();
                }
            }
            catch
            {
                MessageBox.Show("Niste lepo popunili polja");
                Osvezi();
            }
        }

        private void butIzbrisi_Click(object sender, EventArgs e)
        {
            bool status = obus.BrisanjeOsoba(textJMBG.Text);
            if (status)
            {
                MessageBox.Show("Uspesno obrisana osoba");
                DataTable dt = obus.Selektovanje();
                dataGridViewOsobe.DataSource = dt;
                Osvezi();
            }
            else
            {
                MessageBox.Show("Doslo je do greske");
            }
        }

        private void Osvezi()
        {
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
    } }
