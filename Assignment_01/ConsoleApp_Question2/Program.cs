using System.Linq.Expressions;

namespace ConsoleApp_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("First Number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Option ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:

                    Console.WriteLine("Result Adding" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Result Substract" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Result Multiplication" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Result Division" + (num1 / num2));
                    break;
            }
                

           
            
        }
    }
}
