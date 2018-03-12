using System.Collections.Generic;

namespace BaseControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cites = new Dictionary<string, string>();

            string input = "Kharkiv=1431000,Kiev=2804000,Las Vegas=603400";

            Parse parse = new Parse();
            cites = parse.ParsedInput(input);

            string mostPopulatedCity = parse.GetMostpopulatedCity(cites);
            string longestName = parse.GetLongestName(cites);

            Print.printResultDataParsed(mostPopulatedCity, longestName);
        }


    }
}
