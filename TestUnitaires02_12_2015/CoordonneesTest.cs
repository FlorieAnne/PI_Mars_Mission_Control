using PI_Mars_Mission_Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestUnitaires02_12_2015
{
    
    
    /// <summary>
    ///Classe de test pour CoordonneesTest, destinée à contenir tous
    ///les tests unitaires CoordonneesTest
    ///</summary>
    [TestClass()]
    public class CoordonneesTest
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
        ///Test pour Constructeur Coordonnees
        ///</summary>
        [TestMethod()]
        public void CoordonneesConstructorTest()
        {
            Point point = new Point(); // TODO: initialisez à une valeur appropriée
            string descriptif = string.Empty; // TODO: initialisez à une valeur appropriée
            Coordonnees target = new Coordonnees(point, descriptif);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur Coordonnees
        ///</summary>
        [TestMethod()]
        public void CoordonneesConstructorTest1()
        {
            Point point = new Point(); // TODO: initialisez à une valeur appropriée
            Image Icone = null; // TODO: initialisez à une valeur appropriée
            string descriptif = string.Empty; // TODO: initialisez à une valeur appropriée
            Coordonnees target = new Coordonnees(point, Icone, descriptif);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur Coordonnees
        ///</summary>
        [TestMethod()]
        public void CoordonneesConstructorTest2()
        {
            Coordonnees target = new Coordonnees();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur Coordonnees
        ///</summary>
        [TestMethod()]
        public void CoordonneesConstructorTest3()
        {
            Point point = new Point(); // TODO: initialisez à une valeur appropriée
            Coordonnees target = new Coordonnees(point);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour distance
        ///</summary>
        [TestMethod()]
        public void distanceTest()
        {
            Coordonnees target = new Coordonnees(); // TODO: initialisez à une valeur appropriée
            Point point = new Point(); // TODO: initialisez à une valeur appropriée
            double expected = 0F; // TODO: initialisez à une valeur appropriée
            double actual;
            actual = target.distance(point);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Descriptif
        ///</summary>
        [TestMethod()]
        public void DescriptifTest()
        {
            Coordonnees target = new Coordonnees(); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            target.Descriptif = expected;
            actual = target.Descriptif;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Icone
        ///</summary>
        [TestMethod()]
        public void IconeTest()
        {
            Coordonnees target = new Coordonnees(); // TODO: initialisez à une valeur appropriée
            Image expected = null; // TODO: initialisez à une valeur appropriée
            Image actual;
            target.Icone = expected;
            actual = target.Icone;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Position
        ///</summary>
        [TestMethod()]
        public void PositionTest()
        {
            Coordonnees target = new Coordonnees(); // TODO: initialisez à une valeur appropriée
            Point expected = new Point(); // TODO: initialisez à une valeur appropriée
            Point actual;
            target.Position = expected;
            actual = target.Position;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
