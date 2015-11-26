using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;

	
namespace PI_Mars_Mission_Control
{
	[XmlRoot("Jours")]
    public class Journee
    {		

#region Accesseurs & Propriétés

		private int _numJour;
		[XmlElement("N°Jour")]
		public int NumJour
        {
            get { return _numJour; }
            set { _numJour = value; }
        }

		private string _compteRendu;
		[XmlElement("CompteRendu")]
		public string CompteRendu
		{
			get { return _compteRendu; }
			set { _compteRendu = value; }
		}

		private List<Activite> _listActiviteJournee;
		[XmlArray("ListeActivitees")]
		public List<Activite> ListActiviteJournee
		{
			get { return _listActiviteJournee; }
			set { _listActiviteJournee = value; }
		}
		
		
		// Variables statiques
		private static List<Journee> _listeJournees;
		[XmlArray("ListeJournees")]
		public static List<Journee> ListeJournees
		{
			get { return _listeJournees; }
			set { _listeJournees = value; }
		}    


#endregion

		// Constructeur 
		public Journee(int index)
        {					
			NumJour = index;
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
