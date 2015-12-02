using PI_Mars_Mission_Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestJournee.convertionHeureMartienne
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
