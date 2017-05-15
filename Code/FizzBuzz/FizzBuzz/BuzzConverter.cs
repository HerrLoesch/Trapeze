namespace FizzBuzz
{
    public class BuzzConverter : IConverter
    {
        public string Convert(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return string.Empty;
        }
    }
}