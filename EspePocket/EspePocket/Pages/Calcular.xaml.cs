using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calcular : ContentPage
    {
        public Calcular()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            Nota1.Text = "";
            Nota2.Text = "";
            Nota3.Text = "";


        }
        public void Calculo()
        {
            double nota1 = 0, nota2 = 0, nota3 = 0;
            double promedio = 0, promedioaux = 0;
            if (string.IsNullOrWhiteSpace(Nota1.Text) || string.IsNullOrWhiteSpace(Nota2.Text) || string.IsNullOrWhiteSpace(Nota3.Text))
            {
                DisplayAlert("Alerta", "Sus notas no pueden estar vacías", "OK");
            }
            else
            {
                nota1 = Convert.ToDouble(Nota1.Text);
                nota2 = Convert.ToDouble(Nota2.Text);
                nota3 = Convert.ToDouble(Nota3.Text);
                if (nota1 > 20 || nota2 > 20 || nota3 > 20)
                {
                    DisplayAlert("Alerta", "Sus notas no pueden ser mayor a 20", "OK");
                }
                else if (nota1 < 0 || nota2 < 0 || nota3 < 0)
                {
                    DisplayAlert("Alerta", "Sus notas no pueden ser menor a 0", "OK");
                }
                else
                {
                    nota1 = ((nota1 * 6.666) / 20);
                    nota2 = ((nota2 * 6.666) / 20);
                    nota3 = ((nota3 * 6.668) / 20);
                    promedio = nota1 + nota2 + nota3;
                    promedioaux = 14 - (nota1 + nota2);
                    promedioaux = ((promedioaux * 20) / 6.668);
                    if (promedio == 20)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = false;
                        koms.IsVisible = false;
                        kom.IsVisible = true;
                        Promedio.Text = "Tu promedio es:" + Math.Round(promedio, 2) + "\nNivel: Seguro es una optativa";

                    }
                    else if (promedio >= 18 && promedio < 19)
                    {
                        koma.IsVisible = true;
                        komh.IsVisible = false;
                        koms.IsVisible = false;
                        kom.IsVisible = false;
                        Promedio.Text = "Tu promedio es:" + Math.Round(promedio, 2) + "\nNivel: Y como te digo ? niñ@ Z ?";

                    }
                    else if (promedio >= 16 && promedio < 18)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = false;
                        koms.IsVisible = true;
                        kom.IsVisible = false;
                        Promedio.Text = "Tu promedio es:" + Math.Round(promedio, 2) + "\nNivel: Esas desveladas lo valieron";

                    }
                    else if (promedio >= 14.01 && promedio < 16)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = true;
                        koms.IsVisible = false;
                        kom.IsVisible = false;
                        Promedio.Text = "Tu promedio es:" + Math.Round(promedio, 2) + "\nNivel: Otro semestre menos";

                    }
                    else if (promedio >= 14 && promedio < 14.01)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = true;
                        koms.IsVisible = false;
                        kom.IsVisible = false;
                        Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNivel: Felicidades ya puedes salir en memes espe";

                    }
                    else if (promedio >= 12 && promedio < 14)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = false;
                        koms.IsVisible = true;
                        kom.IsVisible = false;
                        if (promedioaux > 20)
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Eeeh.. no creo que el inge acolite en este caso";
                        }
                        else
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas un promedio de: " + Math.Round(promedioaux, 2) + " en el último parcial para aprobar." + "\nNivel: Inge Acolitefff";
                        }



                    }
                    else if (promedio >= 10 && promedio < 12)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = true;
                        koms.IsVisible = false;
                        kom.IsVisible = false;
                        if (promedioaux > 20)
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Prepará esas rodilleras y vaselina";
                        }
                        else
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas un promedio de: " + Math.Round(promedioaux, 2) + " en el último parcial para aprobar." + "\nNivel: Prepará esas rodilleras";
                        }



                    }
                    else if (promedio >= 8 && promedio < 10)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = false;
                        koms.IsVisible = true;
                        kom.IsVisible = false;
                        if (promedioaux > 20)
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: R.I.P X 2";
                        }
                        else
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas un promedio de: " + Math.Round(promedioaux, 2) + " en el último parcial para aprobar." + "\nNivel: R.I.P";
                        }

                    }
                    else if (promedio >= 6 && promedio < 8)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = true;
                        koms.IsVisible = false;
                        kom.IsVisible = false;
                        if (promedioaux > 20)
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Y si vendemos bonice? x 2";
                        }
                        else
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas un promedio de: " + Math.Round(promedioaux, 2) + " en el último parcial para aprobar." + "\nNivel: Y si vendemos bonice?";
                        }

                    }
                    else if (promedio >= 4 && promedio < 6)
                    {
                        koma.IsVisible = true;
                        komh.IsVisible = false;
                        koms.IsVisible = false;
                        kom.IsVisible = false;
                        if (promedioaux > 20)
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Al menos fuiste alguna vez a la u?";
                        }
                        else
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas un promedio de: " + Math.Round(promedioaux, 2) + " en el último parcial para aprobar." + "\nNivel: Al menos fuiste a clases?";
                        }

                    }
                    else if (promedio >= 0 && promedio < 4)
                    {
                        koma.IsVisible = false;
                        komh.IsVisible = false;
                        koms.IsVisible = true;
                        kom.IsVisible = false;
                        if (promedioaux > 20)
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Siempre habrá una tercera oportunidad";
                        }
                        else
                        {
                            Promedio.Text = "Tu promedio es: " + Math.Round(promedio, 2) + "\nNecesitas un promedio de: " + Math.Round(promedioaux, 2) + " en el último parcial para aprobar." + "\nNivel: Siempre habrá una segunda oportunidad";
                        }


                    }
                }

            }

        }

    }
}