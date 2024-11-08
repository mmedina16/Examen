using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }

        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }

        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            double NotaFinal = N1 + N2 + N3;
            return NotaFinal;
        }

        public double CalcularNotaFinal(double N1, double N2, double N3)
        {
            this.N1 = N1;
            this.N2 = N2;
            this.N3 = N3;

            return N1 + N2 + N3;
        }

        public string MensajeNotaFinal(double NotaFinal)
        {
            if (NotaFinal >= 0 && NotaFinal <= 59)
                return "Reprobado";
            else if (NotaFinal >= 60 && NotaFinal <= 79)
                return "Bueno";
            else if (NotaFinal >= 80 && NotaFinal <= 89)
                return "Muy Bueno";
            else if (NotaFinal >= 90 && NotaFinal <= 100)
                return "Sobresaliente";
            else
                return "Nota fuera de rango";
        }

        public void Imprimir()
        {
            Console.WriteLine("********************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo Electronico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal()} - {MensajeNotaFinal(N1 + N2 + N3)}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal(N1, N2, N3)} - {MensajeNotaFinal(N1 + N2 + N3)}");
            Console.WriteLine("********************************");
        }
    }
}
