using System;

namespace homework03task02
{
    class PrimeGenerator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadi pirskaitļu skaitu no 1- 100");
            string input = Console.ReadLine();
            bool inputok = int.TryParse(input, out int count);





            if (inputok = false || count < 1 || count > 100)
            {
                Console.WriteLine("pirmskaitļu skaits ievadīts nepareizi/ vai neatļauti simboli");
            }
            else
            {
                for (int i = 1; i <= count; i++)
                { 
                 if(PrimeOk(i))
                 {
                    Console.Write(i + ", ");
                 }

                }
            }
        }

        public static bool PrimeOk(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;

        }


    }
}
