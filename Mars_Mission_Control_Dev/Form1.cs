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
    public partial class Form1 : Form
    {
        private int period;
        private int jourActuel = 25;
        private int posX = 0;
        private int posY = 0;

        public Form1()
        {
            InitializeComponent();
            Global.ListeJours = new List<Jour>();
            period = 1;

            for (int i = 1; i <= 500; i++)
            {
                Jour jour = new Jour(i);

                jour.Bouton = new Button();

                jour.Bouton.Size = new Size(40, 40);
                jour.Bouton.Text = jour.Bouton.Name = i.ToString();                 
                jour.Bouton.Location = new Point(60 + (posX * 40), 60 + (posY * 40));
                posX++;

                //modulo 50 pour savoir quand mon i arrive à 50
                if (i % 50 == 0)
                {
                    posX = 0;
                    posY = 0;
                }

                //mise à jour des positions, si x depasse le nombre max d'elements en horizontal, on passe à la ligne suivante
                if (posX >= 10)
                {
                    posX = 0;
                    posY++;
                }

                //initialisation : n'afficher que les premier 50 elements sur la page
                if (i <= 50)
                {
                    //ajout des 50 premiers éléments
                    this.Controls.Add(jour.Bouton);
                }
                //gestion de la couleur 
                if (int.Parse(jour.Bouton.Name) < jourActuel)
                {
                    jour.Bouton.BackColor = Color.LightGray;
                }
                else if (int.Parse(jour.Bouton.Name) == jourActuel)
                {
                    jour.Bouton.BackColor = Color.LightBlue;
                    jour.Bouton.Click += jour_Click;//fonction de click sur le bouton 
                }
                else
                {
                    jour.Bouton.BackColor = Color.LightGreen;
                    jour.Bouton.Click += jour_Click;//fonction de click sur le bouton
                }
                Global.ListeJours.Add(jour); //Ajout à la liste
            }
        }

        private void jour_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var jour in Global.ListeJours)
            {
                if(jour.Bouton == ((Button)sender))
                {
                    i = Global.ListeJours.IndexOf(jour);
                }
            }

            Form2 f2 = new Form2(Global.ListeJours[i]);
            f2.Show();
            this.Hide();          
        }

        private void joursSuivants_Click(object sender, EventArgs e)
        {
            //ton truc
            if (period < 10)
            {
                period++;
                //Je vire tous les boutons qui sont dans mon control
                foreach (var jour in Global.ListeJours)
                {
                    this.Controls.Remove(jour.Bouton);
                }
                //Je parcours ma liste et je n'ajoute dans le control que ceux que je veux, à savoir ceux qui se trouvent dans l'intervalle qui m'interesse.
                foreach (var jour in Global.ListeJours)
                {
                    if ((Convert.ToInt64(jour.Bouton.Name) <= period * 50) && (Convert.ToInt64(jour.Bouton.Name) > (period - 1) * 50))//les 50 premiers, puis les 50 suivants..
                    {
                        this.Controls.Add(jour.Bouton);
                    }
                }
            }
        }

        private void joursPrecedents_Click(object sender, EventArgs e)
        {
            if (period > 1)
            {
                period--;
                //Je vire tous les jours qui sont dans mon control
                foreach (var jour in Global.ListeJours)
                {
                    this.Controls.Remove(jour.Bouton);
                }
                //Idem, je parcours ma liste et je n'ajoute dans le control que ceux que je veux, à savoir ceux qui se trouvent dans l'intervalle qui m'interesse.
                foreach (var jour in Global.ListeJours)
                {
                    if ((Convert.ToInt64(jour.Bouton.Name) <= period * 50) && (Convert.ToInt64(jour.Bouton.Name) > (period - 1) * 50))
                    {
                        this.Controls.Add(jour.Bouton);
                    }
                }
            }
        }


    }
}
