using System;

namespace CSharpHomeworkConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment1();
            //Assignment2();
        }

        static void Assignment1()
        {
            string name;
            int age;
            double height;
            bool student;

            // Enter your name
            Console.WriteLine("Enter your name:");
            
            name = Console.ReadLine();
            
            Console.WriteLine("Hello " + name);
            Console.ReadLine();
            // Enter your age
            Console.WriteLine("How old are you?");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age >= 0 && age <= 100)
                {
                    if (age >= 18)
                    {
                        Console.WriteLine("Congratulations, You are an adult.");
                    }
                    else
                    {
                        Console.WriteLine("You are just a kid.");
                    }
                }               
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
            else
            {
                Console.WriteLine("Please, enter a valid number.");
            }

            Console.ReadLine();

            // Enter your height
            Console.WriteLine("What is your height?");
            if (double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("You are really tall.");
            }
            else
            {
                Console.WriteLine("Please, enter a valid height.");
            }

            Console.ReadLine();

            // Are you a student?
            Console.WriteLine("Are you a student? true or false");
            if (bool.TryParse(Console.ReadLine(), out student))
            {
                Console.WriteLine("Welcome " + name + ", please, hit enter.");
            }
            else
            {
                Console.WriteLine("Please, enter true or false.");
            }

            Console.ReadLine();
            Assignment2();
        }

        static void Assignment2()
        {
            double number1, number2;

            Console.WriteLine("Thanks for using the calculator");
            Console.WriteLine("Enter the first number:");
            if (double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Enter the second number:");
                if (double.TryParse(Console.ReadLine(), out number2))
                {
                    double addition = number1 + number2;
                    double subtraction = number1 - number2;
                    double multiplication = number1 * number2;
                    double division = number2 != 0 ? number1 / number2 : double.NaN;

                    // Mostrar resultados
                    Console.WriteLine("Addition: " + addition);
                    Console.WriteLine("Subtraction: " + subtraction);
                    Console.WriteLine("Multiplication: " + multiplication);
                    if (double.IsNaN(division))
                    {
                        Console.WriteLine("Division: Error (cannot divide by zero)");
                    }
                    else
                    {
                        Console.WriteLine("Division: " + division);
                    }
                }
                else
                {
                    Console.WriteLine("Please, enter a valid number for the second input.");
                }
            }
            else
            {
                Console.WriteLine("Please, enter a valid number for the first input.");
            }

            Console.ReadLine();
            Assignment3();
        }

        static void Assignment3()
        {
            Console.WriteLine("Ingrese su calificación (0-100):");
            int calificacion;

            if (int.TryParse(Console.ReadLine(), out calificacion))
            {
                if (calificacion >= 0 && calificacion <= 100)
                {
                    if (calificacion >= 90)
                    {
                        Console.WriteLine("Su calificación es: A");
                    }
                    else if (calificacion >= 80)
                    {
                        Console.WriteLine("Su calificación es: B");
                    }
                    else if (calificacion >= 70)
                    {
                        Console.WriteLine("Su calificación es: C");
                    }
                    else if (calificacion >= 60)
                    {
                        Console.WriteLine("Su calificación es: D");
                    }
                    else
                    {
                        Console.WriteLine("Su calificación es: F");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese una calificación dentro del rango de 0 a 100.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }

            Console.ReadLine();
            Assignment4();
        }

        static void Assignment4()
        {
            Console.WriteLine("Ingrese un número para generar la tabla de multiplicar:");
            int numero;

            // Validar que sea un número entero válido
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Bucle for
                Console.WriteLine($"Tabla de multiplicar del {numero}:");

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");

            }

            Console.ReadLine();
        }
    }
}
