namespace DZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Выбери задачу
34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.;
36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
q - выход из программы");

                string select = Console.ReadLine();
                switch (select)
                {
                    case "34":
                        Zad34();
                        break;
                    case "36":
                        Zad36();
                        break;
                    case "38":
                        Zad38();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                }
            }
        }


        static int[] CreateArray(int size, int min, int max)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(min, max + 1);
            }
            Console.WriteLine($"Массив [{string.Join("; ", array)}]");
            return array;
        }

        static void Zad34()
        {
            Console.WriteLine("Введите количество элементов");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальное значение элемента");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение элемента");
            int max = int.Parse(Console.ReadLine());

            var array = CreateArray(size, min, max);
            int count = 0;
            for (int i = 0; i <= array.Length - 1; i++) 
            { 
                if (array[i] % 2 == 0)
                {
                    count ++;
                }
            }
            Console.WriteLine($"Количество четных чисел = {count}");
        }

        static void Zad36()
        {
            Console.WriteLine("Введите количество элементов");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальное значение элемента");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение элемента");
            int max = int.Parse(Console.ReadLine());

            var array = CreateArray(size, min, max);
            int summ = 0;
            for (int i = 1; i <= array.Length - 1; i+=2)
            {
                summ += array[i];
            }
            Console.WriteLine($"Сумма элементов на нечетных позициях = {summ}");
        }

        static double[] CreateArrayDouble(int size)
        {
            
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().NextDouble() * 100;
            }
            Console.WriteLine($"Массив [{string.Join("; ", array)}]");
            return array;
        }

        static void Zad38()
        {
            Console.WriteLine("Введите количество элементов");
            int size = int.Parse(Console.ReadLine());

            var array = CreateArrayDouble(size);
            Double min = array[0];
            Double max = array[0];

            for (int i = 1; i <= array.Length - 1; i ++)
            {
                if (min > array[i]) { min = array[i]; }
                if (max < array[i]) {  max = array[i]; }
            }

            Console.WriteLine($"Максимальное значение = {max}, Минимальное значение = {min}, Разница = {max - min} ");
        }



    }
}