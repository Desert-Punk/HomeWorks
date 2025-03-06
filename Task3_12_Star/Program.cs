namespace Task3_12_Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне 100–999:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: число должно быть в диапазоне 100–999.");
            }

            // Разделяем число
            int hundreds = number / 100;       // Сотни
            int tens = (number / 10) % 10;     // Десятки
            int units = number % 10;           // Единицы

            // Массивы для преобразования чисел в слова
            string[] hundredsWords = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] tensWords = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] unitsWords = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] teensWords = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

            // Строим текстовое описание числа
            string description = hundredsWords[hundreds] + " ";

            // Обрабатываем десятки и единицы
            if (tens == 1)
            {
                // Числа от 10 до 19
                description += teensWords[units];
            }
            else
            {
                // Десятки
                description += tensWords[tens] + " ";
                // Единицы
                description += unitsWords[units];
            }

            Console.WriteLine(description);
        }
    }
}
