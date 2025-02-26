namespace Task2_2
{
    internal class Program
    {
        /*Угол а задан в градусах, минутах и секундах. 
         * Найти его величину в радианах. 
         * Рекомендации по тестированию: проверить работоспособность программы для углов, больших развернутого.
        */
        static void Main(string[] args)
        {
            Console.Write("Введите градусы: ");
            int degrees = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минуты: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите секунды: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double totalDegrees = degrees + (minutes / 60) + (seconds / 3600);
            double radians = totalDegrees * Math.PI / 180;

            //double totalDegrees = degrees + (minutes / 60) + (seconds / 3600);
            //double pi = 355 / 113; // Приближенное значение π
            //double radians = totalDegrees * pi / 180;

            Console.WriteLine($"Угол в радианах: {radians}");
        }
    }
}
