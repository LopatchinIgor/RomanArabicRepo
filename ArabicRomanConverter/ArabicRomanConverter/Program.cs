using System;

namespace ArabicRomanConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter roman numerals");
            string s = Console.ReadLine().ToUpper();
            ConvertRomanToArabic a = new ConvertRomanToArabic();
            var resulta = a.Convert(s);
            Console.WriteLine(resulta);
            ConvertArabicToRoman b = new ConvertArabicToRoman();
            var c = b.Convert(resulta);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
