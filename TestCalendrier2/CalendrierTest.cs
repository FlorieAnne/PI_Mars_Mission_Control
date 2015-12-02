using PI_Mars_Mission_Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TestCalendrier2
{
    
    
    /// <summary>
    ///Classe de test pour CalendrierTest, destinée à contenir tous
    ///les tests unitaires CalendrierTest
    ///</summary>
    [TestClass()]
    public class CalendrierTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        [ClassInitialize()]
        public static Calendrier MyClassInitialize()
        {
            List<Activite> listeActivite = new List<Activite>();
            List<Journee> listeJournee = new List<Journee>();
            List<Spationaute> listeSpationaute = new List<Spationaute>();
            listeSpationaute.Add(new Spationaute("bobby"));
            listeSpationaute.Add(new Spationaute("John"));
            listeSpationaute.Add(new Spationaute("William"));
            //on remplit les journees
            for (int i = 0; i < 20; i++)
            {
                listeJournee.Add(new Journee(i, listeSpationaute));
            }
            listeJournee[2].ListActiviteJournee[1].Lieu.Position = new Point(30, 40);
            listeJournee[5].ListActiviteJournee[3].Lieu.Position = new Point(20, 50);
            listeJournee[10].ListActiviteJournee[6].Lieu.Position = new Point(-15, 70);
            listeJournee[17].ListActiviteJournee[2].Lieu.Position = new Point(-60, -10);
            DateTime jourDebMission = new DateTime(2015, 11, 15);
            Calendrier leCalendrier = new Calendrier(listeJournee, listeActivite, listeSpationaute);
            return leCalendrier;
        }
        //faire les test sur ce calendrier.

        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///Test pour rechercheLieuExploration
        ///</summary>
        [TestMethod()]
        public void rechercheLieuExplorationTest()
        {
            Calendrier target = MyClassInitialize(); 
            Point pt = new Point(); // TODO: initialisez à une valeur appropriée
            Dates jourdeb = null; // TODO: initialisez à une valeur appropriée
            Dates jourfin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheLieuExploration(pt, jourdeb, jourfin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour serializer
        ///</summary>
        [TestMethod()]
        public void serializerTest()
        {
            Calendrier leCalendrier = MyClassInitialize(); 
            leCalendrier.serializer();
            Assert.IsNotNull(leCalendrier);
        }

        /// <summary>
        ///Test pour selectionPeriode
        ///</summary>
        [TestMethod()]
        public void selectionPeriodeTest()
        {
            Calendrier leCalendrier = MyClassInitialize(); 
            int jourDeb = 4; // TODO: initialisez à une valeur appropriée
            int jourFin = 6; // TODO: initialisez à une valeur appropriée
            List<Journee> expected=new List<Journee>();
            expected.Add(leCalendrier.ListJournees[4]);
            expected.Add(leCalendrier.ListJournees[5]);
            expected.Add(leCalendrier.ListJournees[6]);
            List<Journee> actual;
            actual = leCalendrier.selectionPeriode(jourDeb, jourFin);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour conversionHeureMartienne
        ///</summary>
        [TestMethod()]
        public void conversionHeureMartienneTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            DateTime HeureTerre = new DateTime(); // TODO: initialisez à une valeur appropriée
            Dates expected = null; // TODO: initialisez à une valeur appropriée
            Dates actual;
            actual = target.conversionHeureMartienne(HeureTerre);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
