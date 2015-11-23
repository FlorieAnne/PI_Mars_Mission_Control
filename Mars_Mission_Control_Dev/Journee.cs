using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_Mars_Mission_Control
{
    public class Journee
    {
		private Dates numJour;
		public Dates NumJour
        {
            get { return numJour; }
            set { numJour = value; }
        }

		private int cptJour;
		public int CptJour
		{
			get { return cptJour; }
			set { cptJour = value; }
		}
		

		public Journee()
        {
			Dates date = new Dates();
			
			++CptJour;
			
			NumJour = date.Jour = CptJour;
        }

        private static List<Journee> listeJournees;
        public static List<Journee> ListeJournees
        {
            get { return listeJournees; }
            set { listeJournees = value; }
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

        public void setCompteRendu()
        {
            throw new System.NotImplementedException();
        }

        public Button Btn_jour { get; set; }
    }
}
