﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Serialization;

using System.Text.RegularExpressions;

// SAM
namespace PI_Mars_Mission_Control
{
	[XmlRoot("activite")]
	public class Activite
	{

#region Accesseurs & Propriétés

		private string _nomActivite;
		[XmlElement("Nom")]
		public string NomActivite
		{
			get { return _nomActivite; }
			set 
			{
				// La chaine de caractère en entrée va être comparée à l'expression régulière regex
				//Regex regex = new Regex(@"[A-Za-z]");
				//Match match = regex.Match(NomActivite);
				//if (match.Success)
				//{
				//    _nomActivite = value;
				//}
				//else throw new System.ArgumentException("le nom de l'activité ne doit être composé que de caractère alphabétique");		

				_nomActivite = value;
			}
		}

		private Dates _heureDebut;
		[XmlElement("HeureDebut")]
		public Dates HeureDebut
		{
			get { return _heureDebut; }
			set 
			{
				if (HeureDebut == null)
				{
					_heureDebut = null;
				}
				else
				{
					_heureDebut = value;
				}
			}
		}

		private Dates _heureFin;
		[XmlElement("HeureFin")]
		public Dates HeureFin
		{
			get { return _heureFin; }
			set 
			{
				if (HeureFin == null)
				{
					_heureFin = null;
				}
				else
				{
					_heureFin = value;
				}
			}
		}

        private string _nom;
        [XmlElement("nom")]
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

		private Coordonnees _lieu;
		[XmlElement("Coordonnees")]
		public Coordonnees Lieu
		{
			get { return _lieu; }
			set { _lieu = value; }
		}
		
		private string _description;
		[XmlElement("Description")]
		public string Descritpion
		{
			get { return _description; }
			set { _description = value; }
		}
		
		private List<Spationaute> _listSpationaute;
		[XmlArray("Spationautes")]
		public List<Spationaute> ListSpationaute
		{
			get { return _listSpationaute; }
			set { _listSpationaute = value; }
		}
		

#endregion


#region constructeur
		

		public Activite(String nom, Dates hdeb,Dates hfin, Coordonnees lieu, string desc, List<Spationaute> listSpatio)
		{
			this.NomActivite = nom;

			this.HeureDebut = hdeb;
			this.HeureFin = hfin;
			
			this.Lieu = lieu;
			this.Descritpion = desc;

			this.ListSpationaute = listSpatio;

		}

#endregion


#region méthodes
				
		public void enregister()
        {
            throw new System.NotImplementedException();
        }

        public void rechercheLieuExploration()
        {
            throw new System.NotImplementedException();
		}

#endregion


	}
}
