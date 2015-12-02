using PI_Mars_Mission_Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitaires02_12_2015
{
    
    
    /// <summary>
    ///Classe de test pour DatesTest, destinée à contenir tous
    ///les tests unitaires DatesTest
    ///</summary>
    [TestClass()]
    public class DatesTest
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
        ///Test pour Constructeur Dates
        ///</summary>
        [TestMethod()]
        public void DatesConstructorTest()
        {
            int j = 0; // TODO: initialisez à une valeur appropriée
            int h = 0; // TODO: initialisez à une valeur appropriée
            int m = 0; // TODO: initialisez à une valeur appropriée
            Dates target = new Dates(j, h, m);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int j = 0; // TODO: initialisez à une valeur appropriée
            int h = 0; // TODO: initialisez à une valeur appropriée
            int m = 0; // TODO: initialisez à une valeur appropriée
            Dates target = new Dates(j, h, m); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
