namespace FizzBuzz
{
    public class FizzBuzzCompositeConverter : IConverter
    {
        private IConverter _defaultConverter;
        private IConverter[] _converters;

        public FizzBuzzCompositeConverter(IConverter defaultConverter, params IConverter[] converters)
        {
            _converters = converters;
            _defaultConverter = defaultConverter;
        }

        public string Convert(int number)
        {
            string result = string.Empty;

            foreach (var converter in _converters)
            {
                result += converter.Convert(number);
            }

            if (string.IsNullOrEmpty(result))
            {
                return _defaultConverter.Convert(number);
            }

            return result;
        }
    }
}