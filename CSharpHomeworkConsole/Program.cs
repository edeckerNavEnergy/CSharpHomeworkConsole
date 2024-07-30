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
            //Declare other variables
            Console.WriteLine("Enter you name");
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
        }
    }
}
