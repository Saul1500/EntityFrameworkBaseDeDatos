using Guia_Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
class Program
{
    static void Main()
    {
        using (var contextdb = new ContextDB())
        {
            contextdb.Database.EnsureCreated();

            bool Continuar = true;

            while (Continuar)
            {
                Student estudiante = new Student();

                Console.WriteLine("Ingrese el Nombre: ");
                estudiante.Nombres = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Ingrese el Apellido: ");
                estudiante.Apellidos = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Ingrese el Sexo: ");
                estudiante.Sexo = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Ingrese el Edad: ");
                estudiante.Edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                contextdb.Add(estudiante);
                contextdb.SaveChanges();

                Console.WriteLine("Estudiante agregado correctamente.");

                Console.WriteLine("");

                Console.WriteLine("¿Desea continuar? (S/N): ");
                Console.WriteLine("");
                string Si = Console.ReadLine();
                Continuar = Si.ToLower() == "s";
            }

            Console.WriteLine("Listado de Estudiantes:");

            Console.WriteLine("");

            foreach (var s in contextdb.Estudiantes)
            {
                Console.WriteLine($"Nombre: {s.Nombres}, Apellido: {s.Apellidos}, Sexo: {s.Sexo}, Edad: {s.Edad}");
            }
        }
    }
}

//ALUMNO: JOSE SAUL SIBRIAN SERRANO
