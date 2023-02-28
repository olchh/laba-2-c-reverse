namespace laba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");

            int c = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[c];

            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < c; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Выберите по убыванию или возрастнию будет сортиовасться массив");
            Console.WriteLine("1 or 2");
            int a = Convert.ToInt32(Console.ReadLine());   
            
            
            for (int i = 1; i < mas.Length; i++)
            {
                int elem = mas[i];
                int index = i - 1;

                while (index >= 0 && mas[index] > elem)
                {
                    mas[index + 1] = mas[index];
                    mas[index] = elem;
                    index--;
                }
            }
            Console.Write("Отсортированный массив:" + "{");

            if (a == 1 || a == 2)
            {
                if (a == 1)
                {
                    Array.Reverse(mas);
                }
              
                    for (int i = 0; i < mas.Length; i++)
                    {
                        Console.Write(mas[i]);
                    }
                    Console.Write("}");
                
            }

          

        }
    }
}