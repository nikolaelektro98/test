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
    public partial class usrcKazne : UserControl
    {
        Kazna k = new Kazna();
        KaznaBusiness kbus = new KaznaBusiness();
        List<Kazna> listKazna = new List<Kazna>();
        int idpom;
        

        public usrcKazne()
        {

            InitializeComponent();
            listKazna = kbus.Selektovanje();

            foreach (Kazna k in listKazna)
            {
                comboBoxKazne.Items.Add(k.TipKazne);
            }

        }
       

        private void textTip_Enter(object sender, EventArgs e)
        {
            if (textTip.Text == "Unesi Tip Kazne")
            {
                textTip.Text = "";
                textTip.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textIznos_Enter(object sender, EventArgs e)
        {
            if (textIznos.Text == "Unesi Iznos")
            {
                textIznos.Text = "";
                textIznos.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textZatvor_Enter(object sender, EventArgs e)
        {
            if (textZatvor.Text == "Unesi Sluzenje")
            {
                textZatvor.Text = "";
                textZatvor.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textPoene_Enter(object sender, EventArgs e)
        {
            if (textPoene.Text == "Unesi Poene")
            {
                textPoene.Text = "";
                textPoene.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textTip_Leave(object sender, EventArgs e)
        {
            if (textTip.Text == "")
            {
                textTip.Text = "Unesi Tip Kazne";
                textTip.TextAlign = HorizontalAlignment.Center;
            }

        }

        private void textIznos_Leave(object sender, EventArgs e)
        {
            if (textIznos.Text == "")
            {
                textIznos.Text = "Unesi Iznos";
                textIznos.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textZatvor_Leave(object sender, EventArgs e)
        {
            if (textZatvor.Text == "")
            {
                textZatvor.Text = "Unesi Sluzenje";
                textZatvor.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textPoene_Leave(object sender, EventArgs e)
        {
            if (textPoene.Text == "")
            {
                textPoene.Text = "Unesi Poene";
                textPoene.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void usrcKazne_Load(object sender, EventArgs e)
        {
           

        }

        private void butOsvezi_Click(object sender, EventArgs e)
        {
            
            textTip.Text = "Unesi Tip Kazne";
            textIznos.Text = "Unesi Iznos";
            textZatvor.Text = "Unesi Sluzenje";
            textPoene.Text = "Unesi Poene";

        }

        private void comboBoxKazne_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Kazna k in listKazna)
            {
                if(k.TipKazne == comboBoxKazne.Text)
                {
                    textTip.Text = k.TipKazne;
                    textIznos.Text = k.Iznos.ToString();
                    textZatvor.Text = k.Zatvor.ToString();
                    textPoene.Text = k.Poeni.ToString();
                    idpom = k.Id;
                }
               
            }
            
        }

        private void butDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                k.TipKazne = textTip.Text;
                k.Iznos = Convert.ToInt32(textIznos.Text);
                k.Zatvor = Convert.ToInt32(textZatvor.Text);
                k.Poeni = Convert.ToInt32(textPoene.Text);
                bool status = kbus.UnosKazni(k);
                if (status)
                {
                    MessageBox.Show("Dodata kazna");
                    comboBoxKazne.Items.Clear();
                    listKazna = kbus.Selektovanje();

                    foreach (Kazna k in listKazna)
                    {
                        comboBoxKazne.Items.Add(k.TipKazne);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Niste lepo popunili polja");
               
            }
           


        }

        private void butUpdejtuj_Click(object sender, EventArgs e)
        {
            k.TipKazne = textTip.Text;
            k.Iznos = Convert.ToInt32(textIznos.Text);
            k.Zatvor = Convert.ToInt32(textZatvor.Text);
            k.Poeni = Convert.ToInt32(textPoene.Text);
            k.Id = idpom;
            bool status = kbus.UpdejtovanjeKazne(k);
            if (status)
            {
                MessageBox.Show("Kazna je updejtovana");
                comboBoxKazne.Items.Clear();
                listKazna = kbus.Selektovanje();

                foreach (Kazna k in listKazna)
                {
                    comboBoxKazne.Items.Add(k.TipKazne);
                }
            }

        }

       

        private void butIzbrisi_Click(object sender, EventArgs e)
        {
            bool status = kbus.BrisanjeKazne(idpom);
            if (status)
            {
                MessageBox.Show("Kazna je uspesno obrisana");
                comboBoxKazne.Items.Clear();
                listKazna = kbus.Selektovanje();

                foreach (Kazna k in listKazna)
                {
                    comboBoxKazne.Items.Add(k.TipKazne);
                }
            }

        }
    }
}
