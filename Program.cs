namespace EqualsThirty
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            var setNumber = number.Next(0, 101);


            Console.WriteLine("Give me the first number between 0 and 100, please!");
            var numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me the second number between 0 and 100, please!");
            var numberTwo = Convert.ToInt32(Console.ReadLine());

            bool isThirty = true;

            if (numberOne + numberTwo == 30)
            {
                EqualsThirty(numberOne, numberTwo);
                Console.WriteLine(isThirty = true);
            }
            else if (numberOne + numberTwo != 30)
            {
                EqualsThirty(numberOne, numberTwo);
                Console.WriteLine(isThirty = false);
            }
        }
        static int EqualsThirty(int NumberOne, int NumberTwo)
        {
            return NumberOne + NumberTwo;

        }
    }
}