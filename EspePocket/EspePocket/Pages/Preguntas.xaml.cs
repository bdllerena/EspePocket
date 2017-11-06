using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Preguntas : ContentPage
    {
        public Preguntas()
        {
            InitializeComponent();
            q1.Text = "¿Cuál es el promedio mínimo para aprobar una materia?";
            a1.Text = "El promedio mínimo requerido para la aprobación de las asignaturas es de 14/20.\nReferencia: Art 116.";
            q2.Text = "¿Cuándo se considera pérdida de la gratuidad de manera definitiva?";
            a2.Text = "Se pierde de manera definitiva la gratuidad si un estudiante regular reprueba, en términos acumulativos, el 30% de las materias o créditos de su malla cursada.\nReferencia: Art 80";
            q3.Text = "¿Hasta cuándo puedo dar de baja una materia?";
            a3.Text = "Se podrá retirar voluntariamente de una o varias materias en un plazo de 30 días contados a partir de la fecha de inicio de las actividades académicas.\nReferencia: Art132.";
            q4.Text = "¿Puedo tener acceso a tercera matrícula?";
            a4.Text = "Sí, en los siguientes casos:\n*Cuando un estudiante repruebe por segunda ocasión asignaturas, módulos o proyectos integradores; habiendo completado por lo menos el 80 % de los créditos del total de la malla curricular de su carrera.\n*Cuando el estudiante tenga la materia reprobada con un promedio igual o mayor a 10 puntos.\n*Cuando haciendo uso de su segunda o tercera matrícula, se le haya autorizado, al estudiante, la anulación de matrícula, de todas las asignaturas, módulos, proyectos integradores o cursos tomados en el período, por motivo de enfermedad con diagnóstico grave o por situaciones de caso fortuito o fuerza mayor, que le impidan continuar los estudios.\nReferencia: Art84.";
            q5.Text = "¿Cuántas materias a distancia puedo tomar si sigo una carrera de pre grado presencial?";
            a5.Text = "De acuerdo con lo establecido en Art. 45 del Reglamento de Régimen Académico, los estudiantes podrán tomar durante su carrera, hasta un 15% de las asignaturas en la modalidad de aprendizaje diferente a la que pertenece su Carrera.\nReferencia: Art45.";
            q6.Text = "¿Se puede perder el semestre por faltas?";
            a6.Text = "Sí, si un estudiante excede un número de horas igual o superior al 20% de inasistencia, del total de la carga horaria correspondiente a una asignatura, en la modalidad presencial o semipresencial.\nEl estudiante que obtuviese una calificación final igual o mayor a 16 / 20, en la asignatura tendrá una tolerancia del 5 % más de faltas.\nReferencia: Art.129.";
        }

    }
}