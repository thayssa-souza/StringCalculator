namespace StringCalculator.Domain
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrWhiteSpace(numbers))
                return 0;

            var partsOfNumbers = numbers.Split(',');
            var exceedsCount = partsOfNumbers.Length > 2;
            var consecutiveCommas = partsOfNumbers.Any(x => x == "");
            var nonNumbers = partsOfNumbers.Any(x => !int.TryParse(x, out _));

            if (exceedsCount || consecutiveCommas || nonNumbers)
                throw new ArgumentException(nameof(numbers));

            var sum = partsOfNumbers.Sum(Convert.ToInt32);
        
            return sum;
        }

    }
}