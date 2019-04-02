using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicRomanConverter
{
    public class ConvertArabicToRoman : IConvert<string,int>
    {
        public string Convert(int number)
        {
            var roman = new StringBuilder();

            foreach (var item in RomanArabicDictionary.NumberRomanDictionary)
            {
                while (number >= item.Key)
                {
                    roman.Append(item.Value);
                    number -= item.Key;
                }
            }
            return roman.ToString();
        }
    }
}

