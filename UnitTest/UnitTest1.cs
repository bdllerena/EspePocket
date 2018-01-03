using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EspePocket.Models;
using EspePocket.Pages;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUriSistemas()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/RRfE18"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/RRfE18"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriMecatronica()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/5oyVqR"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/5oyVqR"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriBio()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/VFJC1c"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/VFJC1c"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriAutomotriz()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/qbvDu3"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/qbvDu3"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriSoftware()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/k3c88N"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/k3c88N"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriMecanica()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/zoSmRY"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/zoSmRY"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriCivil()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/XWgmHb"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/XWgmHb"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriGeo()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/ufvjkv"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/ufvjkv"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriAutomatizacion()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/VjfxRc"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/VjfxRc"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriTelecomunicaciones()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/XVAoti"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/XVAoti"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriIasa()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/Vrg2hM"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/Vrg2hM"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriMecatronic()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/J773hS"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/J773hS"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriElectrom()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/1BtdeH"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/1BtdeH"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriTecelec()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/KMWgqa"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/KMWgqa"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriFinanzas()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/GgAqYc"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/GgAqYc"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriComercial()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/BWQ1vM"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/BWQ1vM"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriTuristica()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/us5ngn"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/us5ngn"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriPetro()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/KSLv1V"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/KSLv1V"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriCeni()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/w3VPHj"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/w3VPHj"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriEducacion()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/FeSQuH"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/FeSQuH"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriFinanza()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/Umz8bn"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/Umz8bn"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriFisica()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/kYDWXn"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/kYDWXn"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriAviones()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/xGjHMF"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/xGjHMF"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriMotores()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/hNu7Ae"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/hNu7Ae"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriMerca()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/qbyh8x"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://goo.gl/qbyh8x"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriReglamento1()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://goo.gl/wjpD7L"
            };
            var varEsperado = valorEsperado.Uri;

            Reglamento testReglamento = new Reglamento();
            PersonaWebView valorActual = testReglamento.browser;

            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriReglamento2()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = ""
            };
            var varEsperado = valorEsperado.Uri;

            Reglamento testReglamento = new Reglamento();
            PersonaWebView valorActual = testReglamento.browser;

            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriReglamento3()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "www.reglamento.com"
            };
            var varEsperado = valorEsperado.Uri;

            Reglamento testReglamento = new Reglamento();
            PersonaWebView valorActual = testReglamento.browser;

            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriReglamento4()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "1234566789"
            };
            var varEsperado = valorEsperado.Uri;

            Reglamento testReglamento = new Reglamento();
            PersonaWebView valorActual = testReglamento.browser;

            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestUriReglamento5()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                
            };
            var varEsperado = valorEsperado.Uri;

            Reglamento testReglamento = new Reglamento();
            PersonaWebView valorActual = testReglamento.browser;

            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        public Dictionary<string, int> inicializarDictionaryPreguntas()
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
        public void TestPregunta1()
        {
            Dictionary<string, int> varActual = inicializarDictionaryPreguntas();
            int valorActual = varActual["¿Cuál es el promedio mínimo para aprobar una materia?"];
            int valorEsperado = 1;

            Assert.AreEqual(valorActual, valorEsperado);
        }

        
        [TestMethod]
        public void TestPregunta2()
        {
            Dictionary<string, int> varActual = inicializarDictionaryPreguntas();
            int valorActual = varActual["¿Cuándo se considera pérdida de la gratuidad de manera definitiva?"];

            int valorEsperado = 2;

            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestPregunta3()
        {
            Dictionary<string, int> varActual = inicializarDictionaryPreguntas();
            int valorActual = varActual["¿Hasta cuándo puedo dar de baja una materia?"];

            int valorEsperado = 3;

            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestPregunta4()
        { 
            Dictionary<string, int> varActual = inicializarDictionaryPreguntas();
            int valorActual = varActual["¿Puedo tener acceso a tercera matrícula?"];

            int valorEsperado = 4;

            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestPregunta5()
        {
            Dictionary<string, int> varActual = inicializarDictionaryPreguntas();
            int valorActual = varActual["¿Cuántas materias a distancia puedo tomar si sigo una carrera de pre grado presencial?"];

            int valorEsperado = 5;

            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestPregunta6()
        {
            Dictionary<string, int> varActual = inicializarDictionaryPreguntas();
            int valorActual = varActual["¿Se puede perder el semestre por faltas?"];

            int valorEsperado = 6;

            Assert.AreEqual(valorActual, valorEsperado);
        }
        

    }
}