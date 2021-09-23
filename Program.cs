using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Pilas
{
    class Program
    {
        class EjemploPila
        {
            private int Max;
            private int Top;
            int[] pila;


            public EjemploPila(int tamaño)
            {
                Max = tamaño;
                Top = 0;
                pila = new int[tamaño];
            }

            private bool Llena()
            {
                if (Top == Max) return true;
                return false;
            }
            private bool Vacia()
            {
                if (Top == 0) return true;
                return false;
            }

            public bool Push(int dato)
            {
                if (!Llena())
                {
                    pila[Top] = dato;
                    Top++;
                    return true;
                }
                else return false;
            }

            public bool Pop()
            {
                if (!Vacia())
                {
                    Top--;
                    return true;
                }
                else return false;
            }

            public string Mostrar()
            {
                string resultado = "";
                if (!Vacia())
                {
                    for (int i = 0; i < Top; i++)
                    {
                        resultado += "Posicion: " + i + " Dato: " + pila[i] + "\n";
                    }
                    resultado += "Top: " + Top;
                    resultado += "Maximo: " + Max;
                    return resultado;
                }
                else return resultado = "Pila vacia";
            }

            public void Vaciar()
            {
                Top = 0;
            }

            static void Main(string[] args)
            {
                EjemploPila pila = new EjemploPila(10);
                int respuesta;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Ejemplo de pila");
                    Console.WriteLine("1.- Insertar dato");
                    Console.WriteLine("2.- Eliminar dato");
                    Console.WriteLine("3.- Mostrar datos");
                    Console.WriteLine("4.- Vaciar datos");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese un numero: ");
                            if (pila.Push(int.Parse(Console.ReadLine()))) Console.WriteLine("Dato insertado con exito");
                            else Console.WriteLine("error");

                            break;
                        case 2:
                            if (pila.Pop()) Console.WriteLine("Dato eliminado con exito");
                            else Console.WriteLine("ocurrio un error");
                            break;
                        case 3:
                            Console.WriteLine(pila.Mostrar());
                            break;
                        case 4:
                            pila.Vaciar();
                            break;
                        default:
                            Console.WriteLine("No existe opcion");
                            break;
                    }

                    Console.WriteLine("¿Desea realizar otra opcion?");
                    Console.WriteLine("SI= 1 ------- NO=2");
                    respuesta = int.Parse(Console.ReadLine());
                } while (respuesta == 1);
            }
        }
    }
    }
