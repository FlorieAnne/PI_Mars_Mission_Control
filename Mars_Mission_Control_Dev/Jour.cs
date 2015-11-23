using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PJINFO1
{
    public class Jour
    {
        private int num;
        private Button bouton;


        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public Button Bouton
        {
            get { return bouton; }
            set { bouton = value; }
        }

        public Jour(int num)
        {
            this.num = num;
        }
    }
}
