using PI_Mars_Mission_Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TestCalendrier
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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
        ///Test pour ListSpationaute
        ///</summary>
        [TestMethod()]
        public void ListSpationauteTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            List<Spationaute> expected = null; // TODO: initialisez à une valeur appropriée
            List<Spationaute> actual;
            target.ListSpationaute = expected;
            actual = target.ListSpationaute;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour ListJournees
        ///</summary>
        [TestMethod()]
        public void ListJourneesTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            List<Journee> expected = null; // TODO: initialisez à une valeur appropriée
            List<Journee> actual;
            target.ListJournees = expected;
            actual = target.ListJournees;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour ListActivite
        ///</summary>
        [TestMethod()]
        public void ListActiviteTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            target.ListActivite = expected;
            actual = target.ListActivite;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour JourDebutMission
        ///</summary>
        [TestMethod()]
        public void JourDebutMissionTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            DateTime expected = new DateTime(); // TODO: initialisez à une valeur appropriée
            DateTime actual;
            target.JourDebutMission = expected;
            actual = target.JourDebutMission;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour serializer
        ///</summary>
        [TestMethod()]
        public void serializerTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            target.serializer();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour selectionPeriode
        ///</summary>
        [TestMethod()]
        public void selectionPeriodeTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            int jourDeb = 0; // TODO: initialisez à une valeur appropriée
            int jourFin = 0; // TODO: initialisez à une valeur appropriée
            List<Journee> expected = null; // TODO: initialisez à une valeur appropriée
            List<Journee> actual;
            actual = target.selectionPeriode(jourDeb, jourFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheLieuExploration
        ///</summary>
        [TestMethod()]
        public void rechercheLieuExplorationTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            Point hg = new Point(); // TODO: initialisez à une valeur appropriée
            Point bd = new Point(); // TODO: initialisez à une valeur appropriée
            int jourdeb = 0; // TODO: initialisez à une valeur appropriée
            int jourfin = 0; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheLieuExploration(hg, bd, jourdeb, jourfin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheLieuExploration
        ///</summary>
        [TestMethod()]
        public void rechercheLieuExplorationTest1()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            Point hg = new Point(); // TODO: initialisez à une valeur appropriée
            Point bd = new Point(); // TODO: initialisez à une valeur appropriée
            Dates jourdeb = null; // TODO: initialisez à une valeur appropriée
            Dates jourfin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheLieuExploration(hg, bd, jourdeb, jourfin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheLieuExploration
        ///</summary>
        [TestMethod()]
        public void rechercheLieuExplorationTest2()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
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
        ///Test pour extraireJourSortie
        ///</summary>
        [TestMethod()]
        public void extraireJourSortieTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            List<Journee> expected = null; // TODO: initialisez à une valeur appropriée
            List<Journee> actual;
            actual = target.extraireJourSortie();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
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

        /// <summary>
        ///Test pour Constructeur Calendrier
        ///</summary>
        [TestMethod()]
        public void CalendrierConstructorTest()
        {
            Calendrier target = new Calendrier();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur Calendrier
        ///</summary>
        [TestMethod()]
        public void CalendrierConstructorTest1()
        {
            List<Journee> listeJournees = null; // TODO: initialisez à une valeur appropriée
            List<Activite> listeActivites = null; // TODO: initialisez à une valeur appropriée
            List<Spationaute> listeSpationautes = null; // TODO: initialisez à une valeur appropriée
            Calendrier target = new Calendrier(listeJournees, listeActivites, listeSpationautes);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }
    }
}
