using System;

namespace Project_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Deapason Random Max: ");
            int Deapason = int.Parse(Console.ReadLine());
            if(Deapason > 1) { Func(Deapason); } else
            {
                Console.WriteLine("Invalid Deapason");
            }
            Console.ReadLine();
               
            
        }
        public static void Func(int Deapason)
        {
            Random random = new Random();
            int[] num = new int[100];
            
            int temp;

            //Заполнение рандомными числами массив 
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(1,Deapason);
            }

            ////Сортируем массив
            for (int i = 1; i <= num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

            int[] Chitnoe;
            int[] NeChitnoe;
            string четное = "";
            string нечетное = "";
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Chitnoe = new int[num.Length];
                    Chitnoe[i] = num[i];
                    четное += Chitnoe[i] + " ";
                }
                else
                {
                    NeChitnoe = new int[num.Length];
                    NeChitnoe[i] = num[i];
                    нечетное += NeChitnoe[i] + " ";
                }
            }
            Console.WriteLine("Четное " + четное);
            Console.WriteLine("Не четное " + нечетное);
            Console.ReadLine();
        }
    }
    }

