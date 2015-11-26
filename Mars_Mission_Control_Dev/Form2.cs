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

        public Form2(int jour)
        {
            InitializeComponent();
            jourActuel = Journee.ListeJournees.ElementAt(jour);
            this.tagJourActuel.Text = jour.ToString();
			this.tagJourActuel2.Text = jour.ToString();
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

        private void miseAJourJour(Journee jourApres)
        {           
            this.tagJourActuel.Text = this.tagJourActuel2.Text = jourApres.NumJour.ToString();            
            jourActuel = jourApres;
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {
            if(jourActuel.NumJour != 0)
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
    }
}
