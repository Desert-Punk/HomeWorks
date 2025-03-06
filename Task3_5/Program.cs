namespace Task3_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 10 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}