using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido");
            Console.WriteLine(); 
            Console.WriteLine("--------------------");
            Console.WriteLine("1-Ver lista");
            Console.WriteLine("2-Añadir un Nombre");
            Console.WriteLine("3-Eliminar un Nombre");
            Console.WriteLine("4-Buscar un Nombre");
            Console.WriteLine("--------------------");
            Console.WriteLine("Introduzca un numero");
            Console.WriteLine();

            int Tarea = Convert.ToInt32(Console.ReadLine());

            List<string> Lista = new List<string>();

            Lista.Add("Angel");
            Lista.Add("Jose");
            Lista.Add("Maria");
            Lista.Add("Jessica");
            Lista.Add("Juan");

            if (Tarea == 1)
            {
                Console.Clear();
                foreach (string nombre in Lista)
                {
                    Console.WriteLine(nombre);
                    
                }
                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para salir......");
                Console.ReadKey();
            }

            if (Tarea == 2)
            {
                Console.Clear();
                Console.Write("Ingrese el nombre: ");
                string var = Console.ReadLine();
                Lista.Add(var);

                Console.WriteLine();
                Console.WriteLine("Escriba 1 para ver la Lista");
                Console.WriteLine("Escriba 2 cerrar el programa");
                int Option = Convert.ToInt32(Console.ReadLine());

                if (Option == 1)
                {
                    Console.Clear();
                    foreach (string nombre in Lista)
                    {
                        Console.WriteLine(nombre);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para salir......");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Programa terminado.....");
                    Console.ReadKey();
                }
            }

            if (Tarea == 3)
            {
                Console.Clear();
                foreach (string nombre in Lista)
                {
                    Console.WriteLine(nombre);

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Ingrese el nombre  a remover : ");
                string var = Console.ReadLine();
                Lista.Remove(var);

                Console.WriteLine();
                Console.WriteLine("Escriba 1 para ver la Lista");
                Console.WriteLine("Escriba 2 cerrar el programa");
                Console.WriteLine();
                int Option = Convert.ToInt32(Console.ReadLine());

                if (Option == 1)
                {
                    Console.Clear();
                    foreach (string nombre in Lista)
                    {
                        Console.WriteLine(nombre);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para salir......");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Programa terminado.....");
                    Console.ReadKey();
                }
            }

            if (Tarea == 4)
            {
                Console.Clear();
                Console.Write("Ingrese el nombre  a Buscar : ");
                string var = Console.ReadLine();

                if (var == "Angel")
                {
                    Console.WriteLine("Ese nombre se encuentra en la lista");
                    Console.WriteLine();

                    if (var == "Jose")
                    {
                        Console.WriteLine("Ese nombre se encuentra en la lista");
                        Console.WriteLine();

                        if (var == "Maria")
                        {
                            Console.WriteLine("Ese nombre se encuentra en la lista");
                            Console.WriteLine();

                            if (var == "Jessica")
                            {
                                Console.WriteLine("Ese nombre se encuentra en la lista");
                                Console.WriteLine();

                                if (var == "Juan")
                                {
                                    Console.WriteLine("Ese nombre se encuentra en la lista");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Ese nombre no se encuentra en esta lista...");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
