using PI_Mars_Mission_Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TestUnitaires02_12_2015
{
    
    
    /// <summary>
    ///Classe de test pour JourneeTest, destinée à contenir tous
    ///les tests unitaires JourneeTest
    ///</summary>
    [TestClass()]
    public class JourneeTest
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
        ///Test pour Constructeur Journee
        ///</summary>
        [TestMethod()]
        public void JourneeConstructorTest()
        {
            int index = 0; // TODO: initialisez à une valeur appropriée
            List<Journee> listeJournee = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(index, listeJournee);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur Journee
        ///</summary>
        [TestMethod()]
        public void JourneeConstructorTest1()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour checkActivite
        ///</summary>
        [TestMethod()]
        public void checkActiviteTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            Activite newActivite = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.checkActivite(newActivite);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour duree
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Mars_Mission_Control_Dev.exe")]
        public void dureeTest()
        {
            PrivateObject param0 = null; // TODO: initialisez à une valeur appropriée
            Journee_Accessor target = new Journee_Accessor(param0); // TODO: initialisez à une valeur appropriée
            int heureDeb = 0; // TODO: initialisez à une valeur appropriée
            int heureFin = 0; // TODO: initialisez à une valeur appropriée
            Tuple<Dates, Dates> expected = null; // TODO: initialisez à une valeur appropriée
            Tuple<Dates, Dates> actual;
            actual = target.duree(heureDeb, heureFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheLieuExploration
        ///</summary>
        [TestMethod()]
        public void rechercheLieuExplorationTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            Point hg = new Point(); // TODO: initialisez à une valeur appropriée
            Point bd = new Point(); // TODO: initialisez à une valeur appropriée
            Dates heureDeb = null; // TODO: initialisez à une valeur appropriée
            Dates heureFin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheLieuExploration(hg, bd, heureDeb, heureFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheLieuExploration
        ///</summary>
        [TestMethod()]
        public void rechercheLieuExplorationTest1()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            Point hg = new Point(); // TODO: initialisez à une valeur appropriée
            Point bd = new Point(); // TODO: initialisez à une valeur appropriée
            int heureDeb = 0; // TODO: initialisez à une valeur appropriée
            int heureFin = 0; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheLieuExploration(hg, bd, heureDeb, heureFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheNomActivite
        ///</summary>
        [TestMethod()]
        public void rechercheNomActiviteTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            string mot = string.Empty; // TODO: initialisez à une valeur appropriée
            Dates dateDeb = null; // TODO: initialisez à une valeur appropriée
            Dates dateFin = null; // TODO: initialisez à une valeur appropriée
            target.rechercheNomActivite(mot, dateDeb, dateFin);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour rechercheTexteActivite
        ///</summary>
        [TestMethod()]
        public void rechercheTexteActiviteTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            string mot = string.Empty; // TODO: initialisez à une valeur appropriée
            Dates dateDeb = null; // TODO: initialisez à une valeur appropriée
            Dates dateFin = null; // TODO: initialisez à une valeur appropriée
            target.rechercheTexteActivite(mot, dateDeb, dateFin);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour selectionPeriode
        ///</summary>
        [TestMethod()]
        public void selectionPeriodeTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            int heureDeb = 0; // TODO: initialisez à une valeur appropriée
            int heureFin = 0; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.selectionPeriode(heureDeb, heureFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour selectionPeriode
        ///</summary>
        [TestMethod()]
        public void selectionPeriodeTest1()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            Dates heureDeb = null; // TODO: initialisez à une valeur appropriée
            Dates heureFin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.selectionPeriode(heureDeb, heureFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour serializer
        ///</summary>
        [TestMethod()]
        public void serializerTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            target.serializer();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour CompteRendu
        ///</summary>
        [TestMethod()]
        public void CompteRenduTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            target.CompteRendu = expected;
            actual = target.CompteRendu;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour ListActiviteJournee
        ///</summary>
        [TestMethod()]
        public void ListActiviteJourneeTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            target.ListActiviteJournee = expected;
            actual = target.ListActiviteJournee;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour NumJour
        ///</summary>
        [TestMethod()]
        public void NumJourTest()
        {
            int nJour = 0; // TODO: initialisez à une valeur appropriée
            Form1 f1 = null; // TODO: initialisez à une valeur appropriée
            Journee target = new Journee(nJour, f1); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            target.NumJour = expected;
            actual = target.NumJour;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
