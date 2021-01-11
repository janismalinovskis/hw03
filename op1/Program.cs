using System;
using shapes;
namespace op1
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle figure1 = new rectangle(12, 3);

            Console.WriteLine(figure1.ToString());

            rectangle figure2 = new rectangle(4, 5);
            Console.WriteLine(figure2.ToString());


            rectangle figure3 = new rectangle(6);
            Console.WriteLine(figure3.ToString());


           
 

        }


    }
}
