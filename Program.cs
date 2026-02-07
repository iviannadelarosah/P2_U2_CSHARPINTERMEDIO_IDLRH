using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_U2_CSHARPINTERMEDIO_IDLRH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona un tipo numérico:\n 1) Entero (int)\n 2) Flotante (float)\n 3) Doble precisión (double)\n 4) Decimal (decimal)");
            string typeChoice = Console.ReadLine();
            switch (typeChoice)
            {
                case "1":
                    RunMenu<int>(int.Parse, "Entero (int)");
                    break;
                case "2":
                    RunMenu<float>(float.Parse, "Flotante (float)");
                    break;
                case "3":
                    RunMenu<double>(double.Parse, "Doble precisión (double)");
                    break;
                case "4":
                    RunMenu<decimal>(decimal.Parse, "Decimal (decimal)");
                    break;
                default:
                    Console.WriteLine("Selección inválida.");
                    break;
            }
        }

        static void RunMenu<T>(Func<string, T> parse, string typeName) where T : struct, IComparable, IConvertible
        {
            var list = new ListNumGenerico<T>();
            while (true)
            {
                Console.WriteLine($"\nLista de opciones para: ({typeName}): {list.Count} elementos");
                Console.WriteLine("1) Agregar números");
                Console.WriteLine("2) Suma");
                Console.WriteLine("3) Resta");
                Console.WriteLine("4) Multiplicación");
                Console.WriteLine("5) División");
                Console.WriteLine("6) Salir");
                Console.Write("Seleccionar otra opción: ");
                string option = Console.ReadLine();

                try
                {
                    if (option == "1")
                    {
                        Console.Write($"Inserte un {typeName}: ");
                        string input = Console.ReadLine();
                        T number = parse(input);
                        list.Add(number);
                    }
                    else if (option == "2")
                    {
                        var result = list.Operar((a, b) => (T)Convert.ChangeType(Convert.ToDouble(a) + Convert.ToDouble(b), typeof(T)));
                        Console.WriteLine($"Suma: {result}");
                    }
                    else if (option == "3")
                    {
                        var result = list.Operar((a, b) => (T)Convert.ChangeType(Convert.ToDouble(a) - Convert.ToDouble(b), typeof(T)));
                        Console.WriteLine($"Resta: {result}");
                    }
                    else if (option == "4")
                    {
                        var result = list.Operar((a, b) => (T)Convert.ChangeType(Convert.ToDouble(a) * Convert.ToDouble(b), typeof(T)));
                        Console.WriteLine($"Multiplicación: {result}");
                    }
                    else if (option == "5")
                    {
                        var result = list.Operar((a, b) =>
                        {
                            double denominator = Convert.ToDouble(b);
                            if (denominator == 0)
                                throw new DivideByZeroException("No se puede dividir entre cero.");
                            return (T)Convert.ChangeType(Convert.ToDouble(a) / denominator, typeof(T));
                        });
                        Console.WriteLine($"División: {result}");
                    }
                    else if (option == "6")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opción Inválida.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato de entrada no válido. Ingrese un número válido.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}