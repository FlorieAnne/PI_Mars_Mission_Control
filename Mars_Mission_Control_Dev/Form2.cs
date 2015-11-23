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

        public Form2(Journee jour)
        {
            InitializeComponent();
            jourActuel = jour;
            this.tagJourActuel.Text = jour.Btn_jour.Text;
            this.tagJourActuel2.Text = jour.Btn_jour.Text;
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
            this.tagJourActuel.Text = jourApres.Btn_jour.Text;
            this.tagJourActuel2.Text = jourApres.Btn_jour.Text;
            jourActuel = jourApres;
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {
            int index = Journee.ListeJournees.IndexOf(jourActuel);
            miseAJourJour(Journee.ListeJournees[index -1]);
        }

        private void jourSuivant_Click(object sender, EventArgs e)
        {
            int index = Journee.ListeJournees.IndexOf(jourActuel);            
            miseAJourJour(Journee.ListeJournees[index +1]);
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
