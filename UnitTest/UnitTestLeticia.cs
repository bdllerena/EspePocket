﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EspePocket;
using EspePocket.Pages;
using EspePocket.Models;

namespace UnitTestSelena
{
    [TestClass]
    public class UnitTestLeticia
    {
        [TestMethod]
        public void TestMethodValidacion()
        {
            MaxLengthValidator operation = new MaxLengthValidator();
            int valorActual;
            valorActual = operation.MaxLength = 10;
            int valorEsperado = 10;
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodValidacion2()
        {
            MaxLengthValidator operation = new MaxLengthValidator();
            int valorActual;
            valorActual = operation.MaxLength;
            int valorEsperado = 0;
            Assert.AreEqual(operation.MaxLength, valorEsperado);
        }
        [TestMethod]
        public void TestMethodValidacion3()
        {
            MaxLengthValidator operation = new MaxLengthValidator();
            int valorActual;
            valorActual = operation.MaxLength = 0;
            int valorEsperado = 0;
            Assert.AreEqual(operation.MaxLength, valorEsperado);
        }
        [TestMethod]
        public void TestMethodValidacion4()
        {
            MaxLengthValidator operation = new MaxLengthValidator();
            int valorActual;
            valorActual = operation.MaxLength = 8;
            int valorEsperado = 8;
            Assert.AreEqual(operation.MaxLength, valorEsperado);
        }
        [TestMethod]
        public void TestMethodCEDULA1()

        {
            String cedula = "1111111111";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3APZSDATOSID_espe.prpt/report?userid=consulta&password=consulta&par_cedula=" + cedula + "&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false+"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3APZSDATOSID_espe.prpt/report?userid=consulta&password=consulta&par_cedula=" + cedula + "&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false+"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodCEDULA2()
        {
            String cedula = "1725493769";
            PersonaWebView valorEsperado = new PersonaWebView
            {

                Uri = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3ARZSM0002_Fecha_Matriculacion.prpt/report?userid=consulta&password=consulta&PAR_ID=" + cedula + "&PAR_PERIODO=201720&PAR_NIVEL=UG&PAR_INSTITUCION=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&accepted-page=-1&showParameters=true&renderMode=REPORT"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3ARZSM0002_Fecha_Matriculacion.prpt/report?userid=consulta&password=consulta&PAR_ID=" + cedula + "&PAR_PERIODO=201720&PAR_NIVEL=UG&PAR_INSTITUCION=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&accepted-page=-1&showParameters=true&renderMode=REPORT"
            };
            var varActual = valorActual.Uri;
            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodNRC1()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://autoservicio.espe.edu.ec:9065/pls/PROD/bwckschd.p_disp_detail_sched?term_in=201720&crn_in="
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://autoservicio.espe.edu.ec:9065/pls/PROD/bwckschd.p_disp_detail_sched?term_in=201720&crn_in="
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodCasoNRC2()
        {
            String nrc = "1121";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&htmlProportionalWidth=true&par_nrc=" + nrc + "&par_periodo=201720&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&htmlProportionalWidth=true&par_nrc=" + nrc + "&par_periodo=201720&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }


        [TestMethod]
        public void TestMethodCasoNRC3()
        {
            String nrc = "";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&par_nrc=" + nrc + "&par_periodo=201706&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&par_nrc=" + nrc + "&par_periodo=201706&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodCasoNRC4()
        {
            String nrc = "0000";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&htmlProportionalWidth=true&par_nrc=" + nrc + "&par_periodo=201720&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&htmlProportionalWidth=true&par_nrc=" + nrc + "&par_periodo=201720&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodID1()
        {
            String id = "L00035899";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Ahome%3AUFI%3APAPELETA_MATRICULA_201720.prpt/report?PER=201720&PER_ID=201706&PAR_ID=" + id + "&userid=consulta&password=consulta&output-target=pageable%2Fpdf&accepted-page=-1&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Ahome%3AUFI%3APAPELETA_MATRICULA_201720.prpt/report?PER=201720&PER_ID=201706&PAR_ID=" + id + "&userid=consulta&password=consulta&output-target=pageable%2Fpdf&accepted-page=-1&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodID2()
        {
            String cedula = "0000000000";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }
        [TestMethod]
        public void TestMethodID4()
        {
            String cedula = "0000000000";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodID3()
        {
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3ARZSP0002_BusquedaNRCES.prpt/viewer?userid=consulta&password=consulta"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3ARZSP0002_BusquedaNRCES.prpt/viewer?userid=consulta&password=consulta"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodID4a()
        {
            String cedula = "1111111111";
            PersonaWebView valorEsperado = new PersonaWebView
            {
                Uri = "http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"
            };
            var varEsperado = valorEsperado.Uri;
            PersonaWebView valorActual = new PersonaWebView
            {
                Uri = "http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"
            };
            var varActual = valorActual.Uri;

            Assert.AreEqual(varActual, varEsperado);
        }

        [TestMethod]
        public void TestMethodValidacionPruebas()
        {
            MaxLengthValidator operation = new MaxLengthValidator();
            int valorActual;
            valorActual = operation.MaxLength = 10;
            int valorEsperado = 10;
            Assert.AreEqual(valorActual, valorEsperado);
        }

    }
}
