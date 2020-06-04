using System;


namespace Lab_3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            { 
                Console.Write("Вкажіть довжину масиву: ");
                int len = int.Parse(Console.ReadLine());
                Console.Write("Введіть n: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[len];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Вкажіть наступний елемент: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                System.IO.File.WriteAllText("numbers.txt", string.Join(" ", arr));

                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > n) count++;
                }
                Console.WriteLine($"Кількість чисел, що перевищує {n} є {count}");

                Console.ReadKey();
            }
        }
    }
}
