using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PJINFO1
{
    static class Global
    {
        private static List<Jour> listeJours;

        public static List<Jour> ListeJours
        {
            get { return Global.listeJours; }
            set { Global.listeJours = value; }
        }       
    }
}
