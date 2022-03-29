using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProyectoETS;

namespace PruebasProyectoETS
{
    [TestClass]
    public class UnitariasFechas
    {
        /*[TestMethod]
        public void TestAntesDeCristo()
        {
            
        }*/
        [TestMethod]
        public void Test_Bisiesto()
        {
            int anho1 = 2001;
            int anho2 = 2005;
            int diasAdicional = 1;
            Assert.AreEqual(diasAdicional, Tratar_Fechas.SumarDiaBisiesto(anho1, anho2));
        }

         [TestMethod]
         public void Test_difDias()
         {
            int anho1 = 2001;
            int anho2 = 2002;
            int añoddof = 
         }

         [TestMethod]
         public void TestDiffActual()
         {

         }*/
    }
}
