using System;

namespace homework03
{
    class SortArray
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ievadi masiva garumu no 20- 40");
            string input = Console.ReadLine();
            bool inputok = int.TryParse(input, out int count);





            if (inputok = false || count < 20 || count > 40)
            {
                Console.WriteLine("masiva garums ievadits nepareizi/ vai neatļauti simboli");
            }
            else
            {


                Random rdnum = new Random();
                int[] numbers = new int[count];



                //masīva aizpildīšana gadījuma skaitļiem
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rdnum.Next(50, 101);
                }

                //sakotnejā masīva izvadīšana uz ekrāna
                var result = string.Join(", ", numbers);
                Console.WriteLine(result);

                //masīva kārtošana
                for (int i = 0; i < numbers.Length - 1; i++)





                    for (int j = i + 1; j < numbers.Length; j++)



                        if (numbers[i] > numbers[j])
                        {
                            int temp;
                            temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }


                //sakārtotā masīva izdrukāšana
                foreach (int value in numbers)
                {

                    if (numbers[0]==value)
                    {
                        Console.Write(value);
                    }
                    else
                    {
                        Console.Write(", " + value);
                    }
                    

                }

            }
        }


    }





}
