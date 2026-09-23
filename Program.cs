
namespace Calculator_App
{

    class Calculator
    {
        public string Name;

        public Calculator(string name)
        {
            Name = name;
        }

        public static int Sum(int x,int y)
        {
            return x + y;
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App");
            Console.WriteLine("Local");
        }
    }
}
