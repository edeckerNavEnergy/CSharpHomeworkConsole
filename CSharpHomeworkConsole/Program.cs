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

            }
    }
}
