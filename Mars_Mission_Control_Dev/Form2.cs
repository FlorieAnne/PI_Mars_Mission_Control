﻿using System;
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
        private List<Activite> listActi = new List<Activite>(); // liste des activités
        List<int> listTailles = new List<int>(); // taille en pixel d'une activité
        List<int> listEcart = new List<int>(); // ecart entre 2 activités

        public Form2(int jour)
        {
            InitializeComponent();
            jourActuel = Journee.ListeJournees.ElementAt(jour);
            this.tagJourActuel.Text = jour.ToString();
            this.tagJourActuel2.Text = jour.ToString();
            _taille10minPixel = 2; // 10 minutes = 10 pixel
            // On ajoute toutes les activités par défaut
            Activite Sleeping1 = new Activite(new Dates(0, 0, jourActuel.NumJour), new Dates(7, 0, jourActuel.NumJour), new Coordonnees(new Point(), pictureBox1.Image, "COUCOU"), "texte");
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
                delegate(Activite a1, Activite a2) // Et on les ordonne
                {
                    int HA1 = a1.HeureDebut.heure * 60 + a1.HeureDebut.minute;
                    int HA2 = a2.HeureDebut.heure * 60 + a2.HeureDebut.minute;
                    return HA1.CompareTo(HA2);
                });
            ajusteNbLigne();
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

        private void tailleChaqueCreneaux()
        {
            foreach (Activite i in listActi)
            {
                listTailles.Add(tailleActivite(i));
            }

            listEcart.Add(((listActi[0].HeureFin.heure * 60 + listActi[0].HeureFin.minute) - 0) / 10 * _taille10minPixel); // écart entre heure 0 et première activité

            for (int j = 0; j < listActi.Count() - 1; j++)
            {
                listEcart.Add(((listActi[j + 1].HeureFin.heure * 60 + listActi[j + 1].HeureFin.minute) - (listActi[j].HeureFin.heure * 60 + listActi[j].HeureFin.minute)) / 10 * _taille10minPixel); // écart entre 2 activités
            }

            listEcart.Add(((24 * 60 + 40 - (listActi[listActi.Count - 1].HeureFin.heure * 60 + listActi[listActi.Count - 1].HeureFin.minute))) / 10 * _taille10minPixel); // écart entre dernière activité et 24h40
        }

        private int calculNbLigne()
        {
            IEnumerable<int> listEcartNonNul = listEcart.Where(p => p == 0); // enlève les valeurs nulles de la liste
            int nbEcartNonNul = listEcartNonNul.Count();
            return listTailles.Count + nbEcartNonNul;
        }

        private void ajusteNbLigne()
        {
            tailleChaqueCreneaux();
            tableLayoutPanel1.RowCount = calculNbLigne();

            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.Controls[i].Size = new System.Drawing.Size(100, listTailles[i]);
                tableLayoutPanel1.Controls.Add(new Button(), 0, i);
            }
        }

        // RowCount = nombre de ligne de la table

    }
}
