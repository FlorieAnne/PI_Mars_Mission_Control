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
		#region Accesseurs & Propriétés

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
		
		#endregion
	

	
		// Constructeur

        public Form1()
        {
            InitializeComponent();
			
			// Si la l'objet liste des journées n'est pas créé 
			// Test à remplacer et à faire en fonction de l'importation des détails des journées via le XML
			if (Journee.ListeJournees == null)
			{
				Journee.ListeJournees = new List<Journee>();
				
				for (int i = 0; i < 501; i++)
				{
					Journee jour = new Journee();
					Journee.ListeJournees.Add(jour);
				}
			}

			if (this.ListBtnJour == null)
			{
				ListBtnJour = new List<Button>();
			}

            for (int i = 1; i <= 50; i++)
            {
                Button btn_jour = new Button();
				ListBtnJour.Add(btn_jour);

                btn_jour.Size = new Size(50, 50);

				// Pour le chargement de la 1ère page du calendrier : on sait que le numéro du jour va de 1 à 50
				btn_jour.Text = btn_jour.Name = i.ToString();                 
                btn_jour.Location = new Point(60 + (posX * 50), 60 + (posY * 50));
                posX++;
				

                //mise à jour des positions, si x depasse le nombre max d'elements en horizontal, on passe à la ligne suivante
                if (posX >= 10)
                {
                    posX = 0;
                    posY++;
                }

             
			    this.Controls.Add(btn_jour);
			

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
            }

        }



		// Méthodes

        private void jour_Click(object sender, EventArgs e)
        {
            int NumJour = 0;			
			NumJour = int.Parse(((Button)sender).Text.ToString());
			
			Form2 f2 = new Form2(NumJour);
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
