namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество домов:");
            int n = Convert.ToInt32(Console.ReadLine());

            string wordForm;
            int lastDigit = n % 10;       
            int lastTwoDigits = n % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
            {
                wordForm = "домов";
            }
            else
            {
                switch (lastDigit)
                {
                    case 1:
                        wordForm = "дом";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        wordForm = "дома";
                        break;
                    default:
                        wordForm = "домов";
                        break;
                }
            }

            Console.WriteLine($"Мы построили {n} {wordForm}");
        }
    }
}
