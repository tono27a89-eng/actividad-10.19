using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree un sistema de notas donde el usuario pueda ingresar estudiantes, modificar notas y mostrarlas.");
            Dictionary <string, double> notas = new Dictionary<string, double>();
            int opcion;
            string nombre;
            double num;

            bool validar=false;
            do
            {
                Console.WriteLine("1. ingresar estudiantes");
                Console.WriteLine("2. modificar notas");
                Console.WriteLine("3. ver notas");
                Console.WriteLine("0. salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese cantidad de estudiantes que desae ingresar: ");
                        int.TryParse(Console.ReadLine(), out int lim);
                        for (int i = 0; i < lim; i++)
                        {


                            Console.WriteLine($"Ingrese nombre de estudiante: ");
                            nombre = Console.ReadLine();
                            if (notas.ContainsKey(nombre))
                            {
                                Console.WriteLine("nombre ya existente ingrese otro");
                                i--;
                            }
                            else
                            {
                                Console.WriteLine("ingrese notas: ");
                                double.TryParse(Console.ReadLine(), out num);
                                notas.Add(nombre,num);

                            }
                        }
                        break;
                    case 2:
                        bool validar2 = false;
                        while (validar2 != true)
                        { 
                            Console.WriteLine("ingrese nombre de estudiante que desea modificar");
                            nombre=Console.ReadLine();
                            if (notas.ContainsKey(nombre))
                            {
                                Console.WriteLine("ingrese nueva nota: ");
                                double.TryParse (Console.ReadLine(), out num);
                                notas[nombre] = num;
                            }
                            else
                            {
                                Console.WriteLine("ID no encontrado");
                            }
                        }
                        break;
                    case 3:
                        foreach (var item in notas)
                        {
                            Console.WriteLine(" el nombre: " + item.Key + " notas: " + item.Value);
                        }
                        break;
                    case 0:
                        validar = true;
                        break;
                    default:
                        Console.WriteLine("ingrese valor valido");
                        break;
                }

            }
            while (validar != true);
            Console.WriteLine("hasta luego");

        }
    }
}
