using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_Mars_Mission_Control
{
    public class Journee
    {
        private int index_jour;
    //    private Button btn_jour;

                public int Index_jour
        {
            get { return index_jour; }
            set { index_jour = value; }
        }

     //   public Button Btn_jour
     //   {
     //       get { return btn_jour; }
     //       set { btn_jour = value; }
     //   }

        public Journee(int index_jour)
        {
            this.index_jour = index_jour;
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

		public static Dates NumJour
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

        public Button Btn_journee { get; set; }
    }
}
