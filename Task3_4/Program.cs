namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три разных числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int median;

            if ((a > b && a < c) || (a < b && a > c))
            {
                median = a;
            }
            else if ((b > a && b < c) || (b < a && b > c))
            {
                median = b;
            }
            else
            {
                median = c;
            }

            Console.WriteLine($"Медиана: {median}");
        }
    }
}
