using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculate : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Calculate"/> class.
        /// </summary>
        public Calculate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function reset the fields where the user enters their notes.
        /// </summary>
        public void Reset()
        {
            PointScore1.Text = "";
            PointScore2.Text = "";
            PointScore3.Text = "";
        }

        /// <summary>
        /// This function calculate the average of the three partial marks of the semester
        /// score1 is the note of the first partial
        /// score2 is the note of the second partial
        /// score3 is the note of the third partial
        /// The scores are greater than or equal to 0 and less than or equal to 20
        /// The average has two decimals.
        /// </summary>
        /// <returns>the average</returns>
        public double Calculating()
        {
            double score1 = 0, score2 = 0, score3 = 0;
            double average = 0, averageAux = 0;
            if (string.IsNullOrWhiteSpace(PointScore1.Text) || string.IsNullOrWhiteSpace(PointScore2.Text) || string.IsNullOrWhiteSpace(PointScore3.Text))
            {
                DisplayAlert("Alerta", "Sus notas no pueden estar vacías", "OK");
            }
            else
            {
                score1 = Convert.ToDouble(PointScore1.Text);
                score2 = Convert.ToDouble(PointScore2.Text);
                score3 = Convert.ToDouble(PointScore3.Text);
                if (score1 > 20 || score2 > 20 || score3 > 20)
                {
                    DisplayAlert("Alerta", "Sus notas no pueden ser mayor a 20", "OK");
                }
                else if (score1 < 0 || score2 < 0 || score3 < 0)
                {
                    DisplayAlert("Alerta", "Sus notas no pueden ser menor a 0", "OK");
                }
                else
                {
                    score1 = ((score1 * 6.666) / 20);
                    score2 = ((score2 * 6.666) / 20);
                    score3 = ((score3 * 6.668) / 20);
                    average = score1 + score2 + score3;
                    averageAux = 14 - (score1 + score2);
                    averageAux = ((averageAux * 20) / 6.668);
                    if (average == 20)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = false;
                        Sad.IsVisible = false;
                        Normal.IsVisible = true;
                        FinalGrade.Text = "Tu promedio es:" + Math.Round(average, 2) + "\nNivel: Seguro es una optativa";

                    }
                    else if (average >= 18 && average < 19)
                    {
                        Angry.IsVisible = true;
                        Happy.IsVisible = false;
                        Sad.IsVisible = false;
                        Normal.IsVisible = false;
                        FinalGrade.Text = "Tu promedio es:" + Math.Round(average, 2) + "\nNivel: Y como te digo ? niñ@ Z ?";

                    }
                    else if (average >= 16 && average < 18)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = false;
                        Sad.IsVisible = true;
                        Normal.IsVisible = false;
                        FinalGrade.Text = "Tu promedio es:" + Math.Round(average, 2) + "\nNivel: Esas desveladas lo valieron";

                    }
                    else if (average >= 14.01 && average < 16)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = true;
                        Sad.IsVisible = false;
                        Normal.IsVisible = false;
                        FinalGrade.Text = "Tu promedio es:" + Math.Round(average, 2) + "\nNivel: Otro semestre menos";

                    }
                    else if (average >= 14 && average < 14.01)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = true;
                        Sad.IsVisible = false;
                        Normal.IsVisible = false;
                        FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNivel: Felicidades ya puedes salir en memes espe";

                    }
                    else if (average >= 12 && average < 14)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = false;
                        Sad.IsVisible = true;
                        Normal.IsVisible = false;
                        if (averageAux > 20)
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Eeeh.. no creo que el inge acolite en este caso";
                        }
                        else
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas un promedio de: " + Math.Round(averageAux, 2) + " en el último parcial para aprobar." + "\nNivel: Inge Acolitefff";
                        }



                    }
                    else if (average >= 10 && average < 12)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = true;
                        Sad.IsVisible = false;
                        Normal.IsVisible = false;
                        if (averageAux > 20)
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Prepará esas rodilleras y vaselina";
                        }
                        else
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas un promedio de: " + Math.Round(averageAux, 2) + " en el último parcial para aprobar." + "\nNivel: Prepará esas rodilleras";
                        }



                    }
                    else if (average >= 8 && average < 10)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = false;
                        Sad.IsVisible = true;
                        Normal.IsVisible = false;
                        if (averageAux > 20)
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: R.I.P X 2";
                        }
                        else
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas un promedio de: " + Math.Round(averageAux, 2) + " en el último parcial para aprobar." + "\nNivel: R.I.P";
                        }

                    }
                    else if (average >= 6 && average < 8)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = true;
                        Sad.IsVisible = false;
                        Normal.IsVisible = false;
                        if (averageAux > 20)
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Y si vendemos bonice? x 2";
                        }
                        else
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas un promedio de: " + Math.Round(averageAux, 2) + " en el último parcial para aprobar." + "\nNivel: Y si vendemos bonice?";
                        }

                    }
                    else if (average >= 4 && average < 6)
                    {
                        Angry.IsVisible = true;
                        Happy.IsVisible = false;
                        Sad.IsVisible = false;
                        Normal.IsVisible = false;
                        if (averageAux > 20)
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Al menos fuiste alguna vez a la u?";
                        }
                        else
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas un promedio de: " + Math.Round(averageAux, 2) + " en el último parcial para aprobar." + "\nNivel: Al menos fuiste a clases?";
                        }

                    }
                    else if (average >= 0 && average < 4)
                    {
                        Angry.IsVisible = false;
                        Happy.IsVisible = false;
                        Sad.IsVisible = true;
                        Normal.IsVisible = false;
                        if (averageAux > 20)
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas más de 20 para aprobar." + "\nNivel: Siempre habrá una tercera oportunidad";
                        }
                        else
                        {
                            FinalGrade.Text = "Tu promedio es: " + Math.Round(average, 2) + "\nNecesitas un promedio de: " + Math.Round(averageAux, 2) + " en el último parcial para aprobar." + "\nNivel: Siempre habrá una segunda oportunidad";
                        }


                    }
                }

            }
            return average;

        }

    }
}