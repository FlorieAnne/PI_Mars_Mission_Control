using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;

// ANTOINE	
namespace PI_Mars_Mission_Control
{
	[XmlRoot("Journees")]
    public class Journee
    {		

#region Accesseurs & Propriétés

		private int _numJour;
		[XmlElement("N°Jour")]
		public int NumJour
        {
            get { return _numJour; }
            set 
			{
				if (NumJour >= 0) _numJour = value;
				else throw new System.ArgumentException("le numero du jour doit être positif");			
			}
        }

		private string _compteRendu;
		[XmlElement("CompteRendu")]
		public string CompteRendu
		{
			get { return _compteRendu; }
			set 
			{
				if (value.Length > 400) throw new System.ArgumentException("le compte rendu ne doit pas excéder 300 caractères");
				else _compteRendu = value;
			}
		}

		private List<Activite> _listActiviteJournee;
		[XmlArray("ListeActivitees")]
		public List<Activite> ListActiviteJournee
		{
			get { return _listActiviteJournee; }
			set { _listActiviteJournee = value; }
		}
			
		
        #endregion
        #region constructeurs

        public Journee(int nJour, List<Spationaute> listeSpationaute)
		{
			CompteRendu = "";

			ListActiviteJournee = new List<Activite>();
			
			Dates h0 = new Dates(nJour, 0, 0);
			Dates h7 = new Dates(nJour, 7, 0);
			Dates h8 = new Dates(nJour, 8, 0);
			Dates h12 = new Dates(nJour, 12, 0);
			Dates h14 = new Dates(nJour, 14, 0);
			Dates h19 = new Dates(nJour, 19, 0);
			Dates h21 = new Dates(nJour, 21, 0);
			Dates h23 = new Dates(nJour, 23, 0);
			Dates h24_40 = new Dates(nJour, 24, 40);

			Coordonnees baseMission = new Coordonnees();
			string sleeping = "Sleeping";
			string eating = "Eating";
			string prive = "Private";

			//on ajoute les activites par defaut de la journee.

			ListActiviteJournee.Add(new Activite(sleeping, h0, h7, baseMission, CompteRendu, listeSpationaute));
			ListActiviteJournee.Add(new Activite(eating, h7, h8, baseMission, CompteRendu, listeSpationaute));
			ListActiviteJournee.Add(new Activite(prive, h8, h12, baseMission, CompteRendu, listeSpationaute));
			ListActiviteJournee.Add(new Activite(eating, h12, h14, baseMission, CompteRendu, listeSpationaute));
			ListActiviteJournee.Add(new Activite(prive, h14, h19, baseMission, CompteRendu, listeSpationaute));
			ListActiviteJournee.Add(new Activite(eating, h19, h21, baseMission, CompteRendu, listeSpationaute));
			ListActiviteJournee.Add(new Activite(prive, h21, h23, baseMission, CompteRendu, listeSpationaute));
			ListActiviteJournee.Add(new Activite(sleeping, h23, h24_40, baseMission, CompteRendu, listeSpationaute));
		}

		public Journee(int index, List<Journee> listeJournee)
        {					
			NumJour = index;
            listeJournee.Add(this);
			// ListActiviteJournee = Activite
			CompteRendu = "";
        }
        #endregion
		

#region	Méthodes
		
        public List<Activite> checkActivite(Activite newActivite)
        //on verifie si une activite empiète sur d'autres. Renvoie une liste contenant toutes les activités posant conflit.
        {
            List<Activite> lst_ActiviteConflit = new List<Activite>();
            foreach (Activite activite in ListActiviteJournee)
            {
                if (activite.HeureFin.heure>=newActivite.HeureDebut.heure && activite.HeureFin.minute>=newActivite.HeureDebut.minute)
                {
                    foreach (Spationaute spatioOccupe in activite.ListSpationaute)
                    {
                        foreach (Spationaute spatioNewActivite in newActivite.ListSpationaute)
                        {
                            if (spatioNewActivite == spatioOccupe)
                            {
                                lst_ActiviteConflit.Add(activite);
                            }


                        }
                    }
                }
            }
            return lst_ActiviteConflit;
        }

       
		public void rechercheNomActivite(string mot, Dates dateDeb, Dates dateFin)
		{
            List<Activite> listPeriode = selectionPeriode(dateDeb, dateFin);
            List<Activite> listResult = listPeriode.FindAll(
            delegate(Activite act)
            {
                return (act.Nom==mot);
            }
            );
		}
        public void rechercheTexteActivite(string mot, Dates dateDeb, Dates dateFin)
        {
            List<Activite> listPeriode = selectionPeriode(dateDeb, dateFin);
            List<Activite> listResult = listPeriode.FindAll(
            delegate(Activite act)
            {
                return (act.TexteDescritpif.Contains(mot));
            }
            );
        }


		public List<Activite> selectionPeriode(Dates heureDeb, Dates heureFin)
		{
			List<Activite> lst_periode = new List<Activite>();
			foreach (Activite uneActivite in ListActiviteJournee)
			{
				if (uneActivite.HeureFin.heure > heureDeb.heure || uneActivite.HeureDebut.heure < heureFin.heure)
				{
					lst_periode.Add(uneActivite);
				}
			}
			return lst_periode;
		}


#endregion


        public List<Activite> selectionPeriode(int heureDeb, int heureFin)
        {
            var datesDuree = this.duree(heureDeb, heureFin);
            return selectionPeriode(datesDuree.Item1, datesDuree.Item2);
        }
        public List<Activite> rechercheLieuExploration(Point hg, Point bd, Dates heureDeb, Dates heureFin)
            // hg : point en haut à gauche du rectangle dans lequel on veut chercher
            // bd : point en bas à droite du rectangle dans lequel on veut chercher
        {
            List<Activite> listPeriode=selectionPeriode(heureDeb, heureFin);
            List<Activite>  listResult = listPeriode.FindAll(
            delegate(Activite act)
            {
                return (act.Lieu.Position.X>=hg.X && act.Lieu.Position.X<=bd.X && act.Lieu.Position.Y<=hg.Y && act.Lieu.Position.Y>=bd.Y);
            }
            );
            return listResult;
        }
        public List<Activite> rechercheLieuExploration(Point hg, Point bd, int heureDeb, int heureFin)
        {
            var datesDuree = this.duree(heureDeb, heureFin);
            return rechercheLieuExploration(hg, bd, datesDuree.Item1, datesDuree.Item2);
        }
        private Tuple<Dates, Dates> duree(int heureDeb, int heureFin)
        {
            Dates dateDeb = new Dates(this.NumJour, heureDeb, 0);
            Dates dateFin;
            if (heureFin == 24) dateFin = new Dates(this.NumJour, heureFin, 40);
            else dateFin = new Dates(this.NumJour, heureFin, 0);
            return Tuple.Create(dateDeb, dateFin);
        }

    }
}
