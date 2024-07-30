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

            Console.WriteLine("Welcome " + name);
        }
    }
}
