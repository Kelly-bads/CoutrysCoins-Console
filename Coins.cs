using System.Globalization;

namespace Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal vlr = 10562.25m;
            Console.WriteLine(
                vlr.ToString(
                    "N", 
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )   
            );
        }
    }
}