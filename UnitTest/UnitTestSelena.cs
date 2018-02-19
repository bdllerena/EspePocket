using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestSelena
    {
        
        [TestMethod]
        public void CalcularTest1()
        {
            Calcular operation = new Calcular();
            //Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(14, 14, 14);
            double valorEsperado = 14;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest2()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(20, 20, 20);
            double valorEsperado = 20;
            Assert.AreEqual(valorActual, valorEsperado);
        }
        
        [TestMethod]
        public void CalcularTest3()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(25, 21, 24);
            double valorEsperado = -1;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest4()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(-10, 0, -5);
            double valorEsperado = -1;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest5()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(13.5, 5.3, 10.34);
            double valorEsperado = 9.71;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest6()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(14, 14, 14);
            double valorEsperado = 14;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest7()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(13.99, 13.99, 13.99);
            double valorEsperado = 13.99;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest8()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(15, 20, 0);
            double valorEsperado = 11.666;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest9()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(18.4, 13.7, 12.1);
            double valorEsperado = 14.73;
            Assert.AreEqual(valorActual, valorEsperado);
        }

        [TestMethod]
        public void CalcularTest10()
        {
            Calcular operation = new Calcular();
            double valorActual;
            valorActual = operation.Calculo(15, 15, 15);
            double valorEsperado = 15;
            Assert.AreEqual(valorActual, valorEsperado);
        }

    

    }
}
