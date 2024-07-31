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

            //Declare other variables
            Console.WriteLine("Enter you name");
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("You are an adult");

            Console.WriteLine("What is your size?");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("You are really tall");

            Console.WriteLine("Are you a student? true or false");
            student = bool.Parse(Console.ReadLine());

            Console.WriteLine("Welcome " + name + " please, hit enter");

            Console.ReadLine();

                Assignment2();
            //Assignment2();
            Console.WriteLine("Thanks for using the calculator " + name);
        }
       static void Assignment2()
        {
            double number1, number2;


            Console.WriteLine("Enter the first number:");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = double.Parse(Console.ReadLine());

            double addition = number1 + number2;
            double substraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;

            // Mostrar resultados
            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Subtraction: " + substraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);

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
                    Console.WriteLine("Su calificacion es: A");
                }
                else if (calificacion >= 80)
                {
                    Console.WriteLine("Su calificacion es: B");
                }
                else if (calificacion >= 70)
                {
                    Console.WriteLine("Su calificacion es: C");
                }
                else if (calificacion >= 60)
                {
                    Console.WriteLine("Su calificacion es: D");
                }
                else
                {
                    Console.WriteLine("Su calificacion es: F");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese una calificación dentro del rango de 0 a 100.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número valido.");
        }
            Console.ReadLine();

        }
    }
}
