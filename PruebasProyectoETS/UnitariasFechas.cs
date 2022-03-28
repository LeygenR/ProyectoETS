using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoETS;

namespace PruebasProyectoETS
{
    [TestClass]
    public class UnitariasFechas
    {
        [TestMethod]
        public void TestCorrecto()
        {
            // Arrange
            Codificaciones codificacion = new Codificaciones();

            string error = "";
            string textoIntro = "Ahorrar dinero";
            string textoFinal = "A8o33a3 2i1e3o";

            //Assert
            Assert.AreEqual(textoFinal, codificacion.Metodo_Asimetrico(textoIntro, ref error));

        }

        [TestMethod]
        public void TestNumeros()
        {
            Codificaciones codificacion = new Codificaciones();

            string error = "";
            string numIntro = "123456";
            string numFinal = "123456";

            //Assert
            Assert.AreEqual(numFinal, codificacion.Metodo_Asimetrico(numIntro, ref error));
        }

        [TestMethod]
        public void TestVocales()
        {
            Codificaciones codificacion = new Codificaciones();

            string error = "";
            string vocIntro = "aeiou";
            string vocFinal = "aeiou";

            //Assert
            Assert.AreEqual(vocFinal, codificacion.Metodo_Asimetrico(vocIntro, ref error));

        }

        [TestMethod]
        public void TestEspacio()
        {
            Codificaciones codificacion = new Codificaciones();

            string error = "";
            string espIntro = "  ";
            string espFinal = "  ";

            //Assert
            Assert.AreEqual(espFinal, codificacion.Metodo_Asimetrico(espIntro, ref error));

        }

        [TestMethod]
        public void TestSimbolos()
        {
            Codificaciones codificacion = new Codificaciones();

            string error = "";
            string simbIntro = "$%&€";
            string simbFinal = "$%&€";

            //Assert
            Assert.AreEqual(simbFinal, codificacion.Metodo_Asimetrico(simbIntro, ref error));

        }

    }
}
