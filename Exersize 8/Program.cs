namespace Exersize_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum number: ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                //for loop body
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("Asterisks: ");
            int playerImput = Int32.Parse(Console.ReadLine());

            for (int L = 0; L < playerImput; L++)
            {
                Console.Write("*");
            }
              
            
            }
           

            //Console.WriteLine(number);
        }
    }
