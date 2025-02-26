namespace Task2_3
{
    internal class Program
    {
        /* Длина отрезка задана в дюймах (1 дюйм = 2,54 см). 
         * Перевести значение длины в метрическую систему, 
         * то есть выразить ее в метрах, сантиметрах и миллиметрах. Например, 21 дюйм = 0 м 53 см 3,4 мм
         */
        static void Main(string[] args)
        {
            Console.Write("Введите дюймы: ");
            int inches = Convert.ToInt32(Console.ReadLine());
            double centimeters = 2.54;
            double inch_in_sm = inches * centimeters;
            int total_m = (int)inch_in_sm * 10 / 1000;
            int total_sm = (int)inch_in_sm % 100;
            double total_mm = (inch_in_sm * 10) % 10;

            Console.WriteLine($"{inches} Дюймов = {total_m} м {total_sm} см {total_mm} мм ");
        }
    }
}
 