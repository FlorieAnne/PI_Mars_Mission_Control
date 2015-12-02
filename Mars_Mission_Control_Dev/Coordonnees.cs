using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PI_Mars_Mission_Control
{
    public class Coordonnees
    {
        #region accesseurs & proprietés
        private Point _position;

        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }
        private Image _icone;

        public Image Icone
        {
            get { return _icone; }
            set { _icone = value; }
        }
        private string _descriptif;

        public string Descriptif
        {
            get { return _descriptif; }
            set { _descriptif = value; }
        }
        #endregion
        #region constructeurs
        public Coordonnees()
		{
            Position = 0;
            Icone = null;
            Descriptif = "";
		}
        public Coordonnees(Point point):this()
        {
            Position = point;
        }

        public Coordonnees(Point point, Image Icone, string descriptif)
        {
            this.Position = point;
            this.Icone = Icone;
            this.Descriptif = descriptif;
        }
        #endregion
        #region methodes
        public double distance(Point point)
        {
            double ecartX=this.Position.X-point.X;
            double ecartY=this.Position.Y-point.Y;
            return Math.Sqrt(ecartX * ecartX + ecartY * ecartY);
        }
        #endregion
    }
}
