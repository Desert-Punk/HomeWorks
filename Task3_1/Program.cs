namespace Task3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("=");
            }
            else
            {
                string max = ">";
                string min = "<";
                string nubers = (firstNumber > secondNumber) ? max : min;
                Console.WriteLine(nubers);
            }
        }
    }
}
