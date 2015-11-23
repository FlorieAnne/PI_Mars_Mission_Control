using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_Mars_Mission_Control
{
    public class Journee
    {
        private int num;
        private Button btn_jour;

                public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public Button Btn_jour
        {
            get { return btn_jour; }
            set { btn_jour = value; }
        }

        public Journee(int num)
        {
            this.num = num;
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
