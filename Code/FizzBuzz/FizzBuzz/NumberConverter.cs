namespace FizzBuzz
{
    public class NumberConverter : IConverter
    {
        public string Convert(int number)
        {
            return number.ToString();
        }
    }
}