using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoETS;
using System;
using System.Globalization;

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
            DateTime fecha1 = new DateTime(2001, 10, 19);
            DateTime fecha2 = new DateTime(2002, 10, 19);
            int diasDif = 365;
            Assert.AreEqual(diasDif, Tratar_Fechas.calcularDiasDiff(fecha2, fecha1)); 
        }

        [TestMethod]
        public void Test_difDias_Ac()
        {
            DateTime fechaAC = new DateTime(0001, 10, 19); 
            DateTime fechaDC = new DateTime(0001, 10, 19); 
            int diasDif = 730;
            Assert.AreEqual(diasDif, Tratar_Fechas.CalcularDiasAC(fechaAC, fechaDC)*-1);//colocamos el *(-1) ya que esta operacion se hace al salir de la funcion para cambiar el signo
        }
    }
}
