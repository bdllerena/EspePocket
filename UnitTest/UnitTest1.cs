using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EspePocket.Models;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public Dictionary<string, int> inicializarDictionaryFAQ()
        {
            return new Dictionary<string, int>
            {
                { "¿Cuál es el promedio mínimo para aprobar una materia?", 1 },
                { "¿Cuándo se considera pérdida de la gratuidad de manera definitiva?", 2 }, { "¿Hasta cuándo puedo dar de baja una materia?", 3 },
                { "¿Puedo tener acceso a tercera matrícula?", 4 }, { "¿Cuántas materias a distancia puedo tomar si sigo una carrera de pre grado presencial?", 5 },
                { "¿Se puede perder el semestre por faltas?", 6 }
            };
        }

        [TestMethod]
        public void TestFAQ1()
        {
            Dictionary<string, int> actualR = inicializarDictionaryFAQ();
            int actualResult = actualR["¿Cuál es el promedio mínimo para aprobar una materia?"];
            int expectedR = 1;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestFAQ2()
        {
            Dictionary<string, int> actualR = inicializarDictionaryFAQ();
            int actualResult = actualR["¿Cuándo se considera pérdida de la gratuidad de manera definitiva?"];

            int expectedR = 2;

            Assert.AreEqual(actualResult, expectedR);
        }
        [TestMethod]
        public void TestFAQ3()
        {
            Dictionary<string, int> actualR = inicializarDictionaryFAQ();
            int actualResult = actualR["¿Hasta cuándo puedo dar de baja una materia?"];

            int expectedR = 3;

            Assert.AreEqual(actualResult, expectedR);
        }
        [TestMethod]
        public void TestFAQ4()
        {
            Dictionary<string, int> actualR = inicializarDictionaryFAQ();
            int actualResult = actualR["¿Puedo tener acceso a tercera matrícula?"];

            int expectedR = 4;

            Assert.AreEqual(actualResult, expectedR);
        }
        [TestMethod]
        public void TestFAQ5()
        {
            Dictionary<string, int> actualR = inicializarDictionaryFAQ();
            int actualResult = actualR["¿Cuántas materias a distancia puedo tomar si sigo una carrera de pre grado presencial?"];

            int expectedR = 5;

            Assert.AreEqual(actualResult, expectedR);
        }
        [TestMethod]
        public void TestFAQ6()
        {
            Dictionary<string, int> actualR = inicializarDictionaryFAQ();
            int actualResult = actualR["¿Se puede perder el semestre por faltas?"];

            int expectedR = 6;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriSistemas()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/RRfE18"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/RRfE18"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }


        [TestMethod]
        public void TestUriMecatronica()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/5oyVqR"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/5oyVqR"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriBio()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/VFJC1c"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/VFJC1c"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriAutomotriz()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/qbvDu3"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/qbvDu3"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriSoftware()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/k3c88N"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/k3c88N"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriMecanica()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/zoSmRY"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/zoSmRY"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriCivil()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/XWgmHb"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/XWgmHb"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriGeo()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/ufvjkv"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/ufvjkv"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriAutomatizacion()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/VjfxRc"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/VjfxRc"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriTelecomunicaciones()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/XVAoti"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/XVAoti"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriIasa()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/Vrg2hM"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/Vrg2hM"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriMecatronic()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/J773hS"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/J773hS"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriElectrom()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/1BtdeH"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/1BtdeH"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriTecelec()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/KMWgqa"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/KMWgqa"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriFinanzas()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/GgAqYc"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/GgAqYc"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriComercial()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/BWQ1vM"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/BWQ1vM"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriTuristica()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/us5ngn"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/us5ngn"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriPetro()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/KSLv1V"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/KSLv1V"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriCeni()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/w3VPHj"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/w3VPHj"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriEducacion()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/FeSQuH"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/FeSQuH"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriFinanza()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/Umz8bn"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/Umz8bn"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriFisica()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/kYDWXn"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/kYDWXn"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriAviones()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/xGjHMF"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/xGjHMF"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriMotores()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/hNu7Ae"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/hNu7Ae"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }

        [TestMethod]
        public void TestUriMerca()
        {
            PersonWebView expectedResult = new PersonWebView
            {
                Uri = "https://goo.gl/qbyh8x"
            };
            var expectedR = expectedResult.Uri;
            PersonWebView actualR = new PersonWebView
            {
                Uri = "https://goo.gl/qbyh8x"
            };
            var actualResult = actualR.Uri;

            Assert.AreEqual(actualResult, expectedR);
        }
    }
}
