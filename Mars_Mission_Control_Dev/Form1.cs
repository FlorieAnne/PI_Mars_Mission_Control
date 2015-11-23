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
    public partial class Form1 : Form
    {            
        private int period = 1;
        private int jourActuel = 25;
        private int posX = 0;
        private int posY = 0;
        public Button btn_jour { get; set; }
		
		private List<Button> _listBtnJour;
		public List<Button> ListBtnJour
		{
			get { return _listBtnJour; }
			set { _listBtnJour = value; }
		}

        public Form1()
        {
            InitializeComponent();
            Journee.ListeJournees = new List<Journee>();
				

            for (int i = 1; i <= 50; i++)
            {
                Journee jour = new Journee();

                Button btn_jour = new Button();

                btn_jour.Size = new Size(50, 50);
				btn_jour.Text = btn_jour.Name = jour.NumJour.ToString();                 
                btn_jour.Location = new Point(60 + (posX * 50), 60 + (posY * 50));
                posX++;

                //modulo 50 pour savoir quand mon i arrive à 50
				//if (i % 50 == 0)
				//{
				//    posX = 0;
				//    posY = 0;
				//}

                //mise à jour des positions, si x depasse le nombre max d'elements en horizontal, on passe à la ligne suivante
                if (posX >= 10)
                {
                    posX = 0;
                    posY++;
                }

                //initialisation : n'afficher que les premier 50 elements sur la page
				//if (i <= 50)
				//{
				//    //ajout des 50 premiers éléments
			    this.Controls.Add(btn_jour);
				//}

                //gestion de la couleur 
                if (int.Parse(btn_jour.Name) < jourActuel)
                {
                    btn_jour.BackColor = Color.LightGray;
                }
                else if (int.Parse(btn_jour.Name) == jourActuel)
                {
                    btn_jour.BackColor = Color.LightBlue;
                    btn_jour.Click += jour_Click;//fonction de click sur le Btn_jour 
                }
                else
                {
                    btn_jour.BackColor = Color.LightGreen;
                    btn_jour.Click += jour_Click;//fonction de click sur le Btn_jour
                }
                Journee.ListeJournees.Add(jour); //Ajout à la liste
            }

			// Création des 450 journées suivantes
			for (int i = 51; i < 500; i++)
			{
				Journee jour = new Journee();
				Journee.ListeJournees.Add(jour);
			}

        }

        private void jour_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var jour in Journee.ListeJournees)
            {
                if(btn_jour == ((Button)sender))
                {
                    i = Journee.ListeJournees.IndexOf(jour);
                }
            }

            Form2 f2 = new Form2(Journee.ListeJournees[i]);
            f2.Show();
            this.Hide();          
        }

        private void joursSuivants_Click(object sender, EventArgs e)
        {
            //ton truc
            if (period < 10)
            {
                period++;



				for (int i = 0; i < 50; i++)
				{
					if (this.Controls[i] is Button)
					{
						btn_jour.Text = this.Controls[i].Text;
					}					
				}

                //Je vire tous les Btn_jours qui sont dans mon control
                foreach (var jour in Journee.ListeJournees)
                {
					//if (jour.NumJour)
					//{
						
					//}
                    //this.Controls.Remove(btn_jour);


                }
                //Je parcours ma liste et je n'ajoute dans le control que ceux que je veux, à savoir ceux qui se trouvent dans l'intervalle qui m'interesse.
                foreach (var jour in Journee.ListeJournees)
                {
					//if ((Convert.ToInt64(btn_jour.Name) <= period * 50) && (Convert.ToInt64(btn_jour.Name) > (period - 1) * 50))//les 50 premiers, puis les 50 suivants..
					//{
					//    this.Controls.Add(btn_jour);
					//}
                }
            }
        }

        private void joursPrecedents_Click(object sender, EventArgs e)
        {
            if (period > 1)
            {
                period--;
                //Je vire tous les jours qui sont dans mon control
                foreach (var jour in Journee.ListeJournees)
                {
                    this.Controls.Remove(btn_jour);
                }
                //Idem, je parcours ma liste et je n'ajoute dans le control que ceux que je veux, à savoir ceux qui se trouvent dans l'intervalle qui m'interesse.
                foreach (var jour in Journee.ListeJournees)
                {
                    if ((Convert.ToInt64(btn_jour.Name) <= period * 50) && (Convert.ToInt64(btn_jour.Name) > (period - 1) * 50))
                    {
                        this.Controls.Add(btn_jour);
                    }
                }
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
    }
}
