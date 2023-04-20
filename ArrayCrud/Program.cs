namespace ArrayCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sort(new int[] { 1, 20, -7, 3, 54, 34, 5 });
        }
        public static void Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        numbers[i] = numbers[i] + numbers[j];
                        numbers[j] = numbers[i] - numbers[j];
                        numbers[i] = numbers[i] - numbers[j];
                    }
                }
                Console.WriteLine(numbers[i]);
            }
        }



    }
}