using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using static ProyectoETS.Tratar_Fechas;
using static ProyectoETS.Pedir_Check_Fecha;
using System;

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
        public void TestDiffDia()
        {
            DateTime fecha1 = new DateTime(17/01/1999);
            DateTime fecha2 = new DateTime(21/03/1865);
            int diff = 134;
            Assert.AreEqual(diff, CalcularDiferenciaAnhos(fecha1, fecha2));
        }

       /* [TestMethod]
        public void TestDiffAnhos()
        {

        }

        [TestMethod]
        public void TestDiffActual()
        {

        }*/
    }
}
