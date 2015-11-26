using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_Mars_Mission_Control
{
    public partial class Form2 : Form
    {
        private Journee jourActuel;
        private int _taille10minPixel;
        private List<Activite> listActi = new List<Activite>();

        public Form2(int jour)
        {
            InitializeComponent();
            jourActuel = Journee.ListeJournees.ElementAt(jour);
            this.tagJourActuel.Text = jour.ToString();
            this.tagJourActuel2.Text = jour.ToString();
            _taille10minPixel = 10;
            Activite Sleeping1 = new Activite(new Dates(0,0,jourActuel.NumJour), new Dates(7,0,jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            Activite Sleeping2 = new Activite(new Dates(23, 0, jourActuel.NumJour), new Dates(24, 40, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            Activite Eating1 = new Activite(new Dates(7, 0, jourActuel.NumJour), new Dates(8, 0, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            Activite Eating2 = new Activite(new Dates(12, 0, jourActuel.NumJour), new Dates(14, 0, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            Activite Eating3 = new Activite(new Dates(19, 0, jourActuel.NumJour), new Dates(21, 0, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            Activite Private1 = new Activite(new Dates(8, 0, jourActuel.NumJour), new Dates(12, 0, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            Activite Private2 = new Activite(new Dates(14, 0, jourActuel.NumJour), new Dates(19, 0, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            Activite Private3 = new Activite(new Dates(21, 0, jourActuel.NumJour), new Dates(23, 0, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
            listActi.Add(Sleeping1);
            listActi.Add(Sleeping2);
            listActi.Add(Eating1);
            listActi.Add(Eating2);
            listActi.Add(Eating3);
            listActi.Add(Private1);
            listActi.Add(Private2);
            listActi.Add(Private3);
            listActi.Sort(
                delegate(Activite a1, Activite a2)
                {
                    int HA1 = a1.HeureDebut.heure*60+a1.HeureDebut.minute;
                    int HA2 = a2.HeureDebut.heure*60+a2.HeureDebut.minute;
                    return HA1.CompareTo(HA2);
                });
        }

        private void retourCalendrier_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void miseAJourJour(Journee jourApres)
        {
            this.tagJourActuel.Text = this.tagJourActuel2.Text = jourApres.NumJour.ToString();
            jourActuel = jourApres;
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {
            if (jourActuel.NumJour != 0)
                miseAJourJour(Journee.ListeJournees.ElementAt((jourActuel.NumJour - 1)));
        }

        private void jourSuivant_Click(object sender, EventArgs e)
        {
            if (jourActuel.NumJour != 499)
                miseAJourJour(Journee.ListeJournees.ElementAt((jourActuel.NumJour + 1)));
        }

        private void inserer_Click(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

        }

        public Journee journee { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private int tailleActivite(Activite Activitee)
        {
            return ((Activitee.HeureFin.heure - Activitee.HeureDebut.heure) * 60 + (Activitee.HeureFin.minute - Activitee.HeureDebut.minute)) / 10 * _taille10minPixel;
        }
    }
}
