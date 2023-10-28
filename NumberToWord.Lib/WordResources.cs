using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToWord
{

    internal static class WordResources
    {
        /**
         * Number Notation has been added up to 10^39
         * Decimal type supports up to 10^27
         */
        public static readonly string[] ScaleEng = { "", "hundred", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion", "undecillion", "duodecillion " };
     
        public static readonly string[] ScaleNepEnglish = { "", "hundred", "thousand", "lakh", "crore", "arba", "kharba", "neel", "padma", "shankha", "Upadh", "Anka", "Jald", "Madh", "Parardha", "Anta", "Mahaanta", "Shishanta", "Singhar", "Maha Singhar", "Adanta Singhar" }; //Pow(10,39)
    
        //ENGLISH WORDS RESOURCE
        public static readonly string[] OnesEnglish = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        public static readonly string[] TensEnglish = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

       

        


        //public static IDictionary<(Culture culture, OutputFormat outputFormat), (string CurrencyUnit, string SubCurrencyUnit, string EndOfWordsMarker)> CurrencyDefaults
        //= new Dictionary<(Culture culture, OutputFormat outputFormat), (string CurrencyUnit, string SubCurrencyUnit, string EndOfWordsMarker)>
        //{
        //    {(Culture.International, OutputFormat.English), ("dollar", "cents", "only")},
      
     
        //    //TODO: ADD FOR HINDI
        //};
    }
}
