using System;
using System.Collections.Generic;

namespace BaseControl
{
    public class Parse
    {
        public Dictionary<string, string> ParsedInput(string input)
        {
            Dictionary<string, string> cities = new Dictionary<string, string>();

            try
            {
                string[] InputDatas = input.Split(',');

                foreach (string inputData in InputDatas)
                {
                    string[] CitiesData = inputData.Split('=');
                    cities.Add(CitiesData[0], CitiesData[1]);
                }
            }
            catch (Exception ex)
            {

            }
            return cities;
        }


        public string GetLongestName(Dictionary<string, string> cities)
        {
            string LogestNameCity = string.Empty;
            int CountWordInCity = 0;

            foreach (var item in cities)
            {
                if (item.Key.Length > CountWordInCity)
                {
                    CountWordInCity = item.Key.Length;
                    LogestNameCity = item.Key;
                }
            }

            string longestName = LogestNameCity + "(" + CountWordInCity + " letters)";

            return longestName;
        }

        public string GetMostpopulatedCity(Dictionary<string, string> cities)
        {
            int CountPeople = 0;
            string city = String.Empty;

            foreach (var item in cities)
            {
                if (Convert.ToInt32(item.Value) > CountPeople)
                {
                    CountPeople = Convert.ToInt32(item.Value);
                    city = item.Key;
                }
            }

            string resultMostPopulatedCity = city + " (" + CountPeople + " people)";

            return resultMostPopulatedCity;
        }

    }
}
