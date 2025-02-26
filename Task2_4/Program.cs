namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");
            double length = Convert.ToDouble(Console.ReadLine());

            int roundedLength = (int)Math.Ceiling(length);

            Console.WriteLine($"Округленная длина: {roundedLength}"); ;
        }
    }
}
