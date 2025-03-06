namespace Task3_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= -10 || number >= 10)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            };
        }
    }
}
