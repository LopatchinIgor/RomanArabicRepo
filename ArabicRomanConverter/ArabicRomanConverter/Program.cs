using System;
using System.Text;
using System.Threading.Tasks;

namespace ArabicRomanConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter roman numerals");
            string s = Console.ReadLine().ToUpper();
            ConvertRomanToArabic a = new ConvertRomanToArabic();
            a.Convert(s);
            ConvertArabicToRoman b = new ConvertArabicToRoman();
            var c = b.Convert(15);
            Console.ReadKey();
        }
    }


}
    
    


