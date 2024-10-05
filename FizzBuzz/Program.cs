namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 100)
            {
                string OutputI = i.ToString();

                if (i % 3 == 0 & i % 5 == 0)
                {
                    OutputI = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    OutputI = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    OutputI = "Buzz";
                }
                
                Console.WriteLine(OutputI);

                i++;
            }
        }
    }
}
