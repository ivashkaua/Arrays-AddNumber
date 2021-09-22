using System;

namespace Array_add_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: \t");
            int ArrNumber = int.Parse(Console.ReadLine());
            int[] array = new int[ArrNumber];

            for (int l = 0; l < ArrNumber; l++)
            {
                Console.Write($"\nВведите число с индексом {l} \t");
                array[l] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Введите число, которое хотите добавить к массиву: \t");
            int addnumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            int range = ArrNumber + 1;
            int[] ArrUpdated = new int[range];

            Console.WriteLine(range);

            Console.WriteLine("Теперь Ваш массив выглядит следующим образом: ");
            for (int i = 0; i < ArrNumber; i++)
            {
                Console.WriteLine("\n" + array[i]);
            }
            ArrUpdated[range-1] = addnumber;
            Console.WriteLine("\n" + ArrUpdated[range - 1]);
            Console.WriteLine();
            Console.WriteLine(ArrUpdated);
            Console.ReadLine();
        }
    }
}
