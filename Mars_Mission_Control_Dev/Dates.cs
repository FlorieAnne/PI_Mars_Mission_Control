using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_Mars_Mission_Control
{
	public class Dates
    {
        public int heure;

		public int minute;
		
        public int jour;

        public Dates(int h, int m, int j)
        {
            heure = h;
            minute = m;
            jour = j;
        }
    }
}
