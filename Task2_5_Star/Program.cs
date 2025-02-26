namespace Task2_5_Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");
            double length = Convert.ToDouble(Console.ReadLine());

            double roundedLength = Math.Round(length * 2, MidpointRounding.AwayFromZero) / 2;

            Console.WriteLine($"Округленная длина: {roundedLength}");
        }
    }
}
