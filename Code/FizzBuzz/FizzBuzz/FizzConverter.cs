namespace FizzBuzz
{
    public class FizzConverter : IConverter
    {
        public string Convert(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            return string.Empty;
        }
    }
}