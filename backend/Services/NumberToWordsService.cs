namespace NumberToWordsAPI.Services
{
    public class NumberToWordsService
    {
        public string ConvertToWords(decimal number)
        {
            long dollars = (long)Math.Floor(number);
            int cents = (int)((number - dollars) * 100);

            string dollarWords = NumberToWords(dollars);
            string centWords = NumberToWords(cents);

            return $"{dollarWords} DOLLARS AND {centWords} CENTS";
        }

        private string NumberToWords(long number)
        {
            if (number == 0)
                return "ZERO";

            if (number < 0)
                return "MINUS " + NumberToWords(Math.Abs(number));

            string words = "";

            string[] unitsMap = {
                "ZERO","ONE","TWO","THREE","FOUR","FIVE","SIX","SEVEN","EIGHT","NINE",
                "TEN","ELEVEN","TWELVE","THIRTEEN","FOURTEEN","FIFTEEN","SIXTEEN",
                "SEVENTEEN","EIGHTEEN","NINETEEN"
            };

            string[] tensMap = {
                "ZERO","TEN","TWENTY","THIRTY","FORTY","FIFTY",
                "SIXTY","SEVENTY","EIGHTY","NINETY"
            };

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " MILLION ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " HUNDRED ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "AND ";

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];

                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words.Trim();
        }
    }
}