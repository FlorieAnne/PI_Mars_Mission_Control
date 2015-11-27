using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Serialization;


namespace PI_Mars_Mission_Control
{
    [XmlRoot("Calendrier")]
    public class Calendrier
    {


#region Accesseurs & Propriétés

                
        private DateTime _jourDebutMission;
        [XmlElement("JourDebutMission")]
        public DateTime JourDebutMission
        {
            get { return _jourDebutMission; }
            set { _jourDebutMission = value; }
        }


        private List<Journee> _listeJournees;
        [XmlArray("ListeJournees")]
        public List<Journee> ListeJournees
        {
            get { return _listeJournees; }
            set { _listeJournees = value; }
        }    


        private List<Spationaute> _listSpationaute;
        [XmlArray("ListSpationaute")]
        public List<Spationaute> ListSpationaute
        {
            get { return _listSpationaute; }
            set { _listSpationaute = value; }
        }

        private List<Activite> _listActivite;
        [XmlArray("ListActivite")]
        public List<Activite> ListActivite
        {
            get { return _listActivite; }
            set { _listActivite = value; }
        }


#endregion


        public Calendrier()
        {
            //this.ListeJournees = new List<Journee>();
            //this.ListActivite = new List<Activite>();
            //this.ListSpationaute = new List<Spationaute>();
        }



#region méthodes


        public void selectionPeriode()
        {
            throw new System.NotImplementedException();
        }

		public System.Collections.Generic.List<PI_Mars_Mission_Control.Journee> extraireJourSortie()
		{
			throw new System.NotImplementedException();
		}

		public void conversionHeureMartienne()
		{
			throw new System.NotImplementedException();
        }


#endregion


    }
}
