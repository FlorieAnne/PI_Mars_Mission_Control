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
		
#region Constructeur

        public Form1()
        {
            InitializeComponent();
			
			// Si la l'objet liste des journées n'est pas créé 
			// Test à remplacer et à faire en fonction de l'importation des détails des journées via le XML
			//if (Journee.ListeJournees == null)
			//{
            Calendrier cal = new Calendrier();

				Journee.ListeJournees = new List<Journee>();
				
				for (int i = 0; i < 500; i++)
				{
					Journee jour = new Journee(i);
				}
			//}

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
			    btn_jour.Click += jour_Click;//fonction de click sur le Btn_jour

                //gestion de la couleur 
                if (int.Parse(btn_jour.Name) < jourActuel)
                    btn_jour.BackColor = Color.LightGray;
                else if (int.Parse(btn_jour.Name) == jourActuel)
                    btn_jour.BackColor = Color.LightBlue;
                else
                    btn_jour.BackColor = Color.LightGreen;                  
                              
            }

        }

#endregion

#region Méthodes

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
            Button tmpBtn;
            if (period < 10)
            {
                period++;
                
				for (int i = 0; i < 50; i++)
				{   
                    tmpBtn = ListBtnJour.ElementAt(i);
                    int tmp = int.Parse((ListBtnJour.ElementAt(i).Text.ToString())); //On récupère la valeur du numéro du jour
                    tmp += 50; // On lui ajoute 50
                    tmpBtn.Text = tmp.ToString(); // Et on la remplace
                    
                    //color                    
                    if (tmp < jourActuel)
                        tmpBtn.BackColor = Color.LightGray;
                    else if (tmp == jourActuel)
                        tmpBtn.BackColor = Color.LightBlue;
                    else
                        tmpBtn.BackColor = Color.LightGreen;     

				}
            }
        }

        private void joursPrecedents_Click(object sender, EventArgs e)
        {
            Button tmpBtn;
            if (period > 1)
            {
                period--;

                for (int i = 0; i < 50; i++)
                {
                    tmpBtn = ListBtnJour.ElementAt(i);
                    int tmp = int.Parse((ListBtnJour.ElementAt(i).Text.ToString())); // On récupère la valeur du numéro du jour
                    tmp -= 50; // On lui enlève 50
                    tmpBtn.Text = tmp.ToString(); // Et on la replace

                    //color                    
                    if (tmp < jourActuel)
                        tmpBtn.BackColor = Color.LightGray;
                    else if (tmp == jourActuel)
                        tmpBtn.BackColor = Color.LightBlue;
                    else
                        tmpBtn.BackColor = Color.LightGreen;     
                }
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

        }

#endregion

		private void Form1_Load(object sender, EventArgs e)
		{

		}

    }
}
