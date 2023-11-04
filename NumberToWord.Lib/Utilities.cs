using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace NumberToWord
{
    internal static class Utilities
    {
        /// <summary>
        /// Capitalizes the first letter of input string
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        internal static string CapitalizeFirstLetter(this string words)
        {
            if (string.IsNullOrEmpty(words)) throw new ArgumentException("Input string must not be null or empty");
            return words.First().ToString(CultureInfo.InvariantCulture).ToUpper(CultureInfo.InvariantCulture) + words.Substring(1);
        }

        /// <summary>
        /// Used to initialize the conversion factory as per the specified options
        /// </summary>
        /// <param name="options"></param>
        internal static ConversionFactory InitializeConversionFactory(NumericWordsConversionOptions options)
        {
            ManageSuitableResources(out string[] ones, out string[] tens, out string[] scale, options);
            return new ConversionFactory(options, ones, tens, scale);
        }

        /// <summary>
        /// Output resources for words conversion as per the specified options
        /// </summary>
        /// <param name="ones">Output parameter for ones digit</param>
        /// <param name="tens">Output parameter for tens digit</param>
        /// <param name="scale">Output parameter for scale of specified culture</param>
        /// <param name="options">Options used for resources output</param>
        internal static void ManageSuitableResources(out string[] ones, out string[] tens, out string[] scale, NumericWordsConversionOptions options)
        {
            switch (options.Culture)
            {
                
                case Culture.International:
                    scale = WordResources.ScaleEng;
                    ones = WordResources.OnesEnglish;
                    tens = WordResources.TensEnglish;
                    break;
                case Culture.SouthernAsia:
                    switch (options.OutputFormat)
                    {
                        case OutputFormat.English:
                            ones = WordResources.OnesEnglish;
                            tens = WordResources.TensEnglish;
                            scale = WordResources.ScaleNepEnglish;
                            break;
                      
                       
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(options.Culture), options.Culture, "Invalid Culture in Conversion Options");
            }
        }
    }
}
