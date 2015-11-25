using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_Mars_Mission_Control
{
    public class Journee
    {
		public Button Btn_jour { get; set; }

		// Accesseurs & Propriétés
		private int _numJour;
		public int NumJour
        {
            get { return _numJour; }
            set { _numJour = value; }
        }

		public string CompteRendu
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public List<Activite> ListActiviteJournee
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}


		// Variables statiques
		private static List<Journee> _listeJournees;
		public static List<Journee> ListeJournees
		{
			get { return _listeJournees; }
			set { _listeJournees = value; }
		}    

		private static int _cptJour;
		public static int CptJour
		{
			get { return _cptJour; }
			set { _cptJour = value; }
		}
		

		// Constructeur 
		public Journee()
        {			
			// A chaque création d'objet on incrémente le compteur statique
			++CptJour;			
			NumJour = CptJour;
			ListeJournees.Add(this);
        }
				  
		

		// Méthodes
        public void setCompteRendu()
        {
            throw new System.NotImplementedException();
        }


		//public Journee getJournee(int numJour)
		//{
		//    foreach (var journee in ListeJournees)
		//    {
		//        if (journee.NumJour == numJour)
		//        {
		//            return journee;
		//        }
		//    }

		//    return null;
		//}

        
    }
}
