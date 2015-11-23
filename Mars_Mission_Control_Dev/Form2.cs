using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PJINFO1
{
    public partial class Form2 : Form
    {
        private Jour jourActuel;

        public Form2(Jour jour)
        {
            InitializeComponent();
            jourActuel = jour;
            this.tagJourActuel.Text = jour.Bouton.Text;
            this.tagJourActuel2.Text = jour.Bouton.Text;
        }

        private void retourCalendrier_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void miseAJourJour(Jour jourApres)
        {
            this.tagJourActuel.Text = jourApres.Bouton.Text;
            this.tagJourActuel2.Text = jourApres.Bouton.Text;
            jourActuel = jourApres;
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {
            int pop = Global.ListeJours.IndexOf(jourActuel);
            miseAJourJour(Global.ListeJours[pop -1]);
        }

        private void jourSuivant_Click(object sender, EventArgs e)
        {
            int pop = Global.ListeJours.IndexOf(jourActuel);            
            miseAJourJour(Global.ListeJours[pop +1]);
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
    }
}
