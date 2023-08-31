using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policijska_Uprava
{
   
    public partial class frmPolicijskaUprava : Form
    {


        Osoba o = new Osoba();
        OsobaRepository obus = new OsobaRepository();
        List<Osoba> listOsoba = new List<Osoba>();
        Kazna k = new Kazna();
        KaznaRepository kbus = new KaznaRepository();
        List<Kazna> listKazna = new List<Kazna>();
        Dosije d = new Dosije();
        DosijeBusiness dbus = new DosijeBusiness();
        private bool mouseDown;
        private Point lastLocation;

        public frmPolicijskaUprava()
        {
           
            InitializeComponent();
            listOsoba = obus.SelektovanjeLista();
        }
        private void frmPolicijskaUprava_Load(object sender, EventArgs e)
        {
            panelAktivni.Height = butPocetna.Height;
            panelAktivni.Top = butPocetna.Top;
            registar1.Hide();
            usrcKazne1.Hide();
            dosije1.Hide();
            usrPolicajac1.Hide();
            osnovniPodaci1.Hide();
        }

        private void butPocetna_Click(object sender, EventArgs e)
        {
            panelAktivni.Height = butPocetna.Height;
            panelAktivni.Top = butPocetna.Top;
            registar1.Hide();
            usrcKazne1.Hide();
            dosije1.Hide();
            usrPolicajac1.Hide();
            osnovniPodaci1.Hide();

            textPretraga.Text = "Unesi JMBG";
            textPretraga.TextAlign = HorizontalAlignment.Center;
        }

        private void butRegistar_Click(object sender, EventArgs e)
        {
            panelAktivni.Height = butRegistar.Height;
            panelAktivni.Top = butRegistar.Top;
            registar1.Show();
            usrcKazne1.Hide();
            osnovniPodaci1.Hide();
            dosije1.Hide();
            usrPolicajac1.Hide();


        }

        private void butDosije_Click(object sender, EventArgs e)
        {
            panelAktivni.Height = butDosije.Height;
            panelAktivni.Top = butDosije.Top;
            registar1.Hide();
            usrcKazne1.Hide();
            usrPolicajac1.Hide();
            osnovniPodaci1.Hide();
            dosije1.Show();
        }

        private void butKazne_Click(object sender, EventArgs e)
        {
            panelAktivni.Height = butKazne.Height;
            panelAktivni.Top = butKazne.Top;
            usrcKazne1.Show();
            dosije1.Hide();
            usrPolicajac1.Hide();
            osnovniPodaci1.Hide();

        }
        private void butPolicajac_Click(object sender, EventArgs e)
        {
            panelAktivni.Height = butPolicajac.Height;
            panelAktivni.Top = butPolicajac.Top;
            registar1.Hide();
            usrcKazne1.Hide();
            dosije1.Hide();
            osnovniPodaci1.Hide();
            usrPolicajac1.Show();
        }

        private void butnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Code for moving form*/ 

        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelHead_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        /* -----------------------------------------------------------------------------------*/

        private void textPretraga_MouseClick(object sender, MouseEventArgs e)
        {
            if (textPretraga.Text == "Unesi JMBG")
            {
                textPretraga.Text = "";
                textPretraga.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void butTrazi_Click(object sender, EventArgs e)
        {
            listOsoba = obus.SelektovanjeLista();
            foreach (Osoba o1 in listOsoba)
            {
                if (textPretraga.Text == o1.Jmbg)
                {
                    
                    osnovniPodaci1.Show();
                    osnovniPodaci1.Dodela(textPretraga.Text);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
