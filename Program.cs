using Examen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



class Program {

    static void Main(string[] args)
    {
        Asignatura asignatura = new Asignatura();

        Console.WriteLine("Ingrese el nombre del alumno: ");
        asignatura.NombreAlumno = Console.ReadLine();
        Console.WriteLine("Ingrese el numero de cuenta: ");
        asignatura.NumeroCuenta = Console.ReadLine();
        Console.WriteLine("Ingrese el correo electronico: ");
        asignatura.Email = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre de la clase: ");
        asignatura.NombreAsignatura = Console.ReadLine();
        Console.WriteLine("Ingrese el horario de la clase: ");
        asignatura.Horario = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del docente: ");
        asignatura.NombreDocente = Console.ReadLine();

        bool salir = false;
        {
            while (!salir)
            {
                try
                {
                    Console.WriteLine("Ingrese la nota del primer parcial: ");
                    asignatura.N1 = Convert.ToDouble(Console.ReadLine());
                    if (asignatura.N1 > 30)
                    {
                        Console.WriteLine("La nota no debe ser mayor a 30%\n");
                        continue;
                    }
                    Console.WriteLine("Ingrese la nota del segundo parcial: ");
                    asignatura.N2 = Convert.ToDouble(Console.ReadLine());
                    if (asignatura.N2 > 30)
                    {
                        Console.WriteLine("La nota no debe ser mayor a 30%\n");
                        continue;
                    }
                    Console.WriteLine("Ingrese la nota del tercer parcial: ");
                    asignatura.N3 = Convert.ToDouble(Console.ReadLine());
                    if (asignatura.N3 > 40)
                    {
                        Console.WriteLine("La nota no debe ser mayor a 40%\n");
                        continue;
                    }
                    salir = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        asignatura.Imprimir();
        

    }

    }