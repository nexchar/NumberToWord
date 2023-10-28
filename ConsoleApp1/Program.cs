using NumberToWord;

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyWordsConverter converter = new CurrencyWordsConverter(new CurrencyWordsConversionOptions()
            {
                Culture = Culture.Hindi,
                OutputFormat = OutputFormat.English,
                CurrencyUnitSeparator = string.Empty,
                CurrencyUnit = "pound",
                SubCurrencyUnit = "pence",
           
            });
            string words = converter.ToWords(105000.25M);

            //words = number.To
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}
