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
                Culture = Culture.International,
                OutputFormat = OutputFormat.English,
                CurrencyUnitSeparator = string.Empty,
                CurrencyUnit = "pound",
                SubCurrencyUnit = "pence",
           
            });
            string words = converter.ToWords(105000.25M);

         
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}
