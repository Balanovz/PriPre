using System;
using System.Text;
using System.Text.RegularExpressions;


namespace PREPRI
{
    public class Master
    {
        public static string Parser(string inputString)
        {
            string[] splitWords = inputString.Split(' ');
            var result = new StringBuilder();
            string temp = "";

            foreach (var i in splitWords)
            {
                if (Regex.IsMatch(i, "[Пп]ри|ие"))
                {
                    temp = Regex.Replace(i, @"При", "Пре");
                    temp = Regex.Replace(temp, @"при", "пре");
                    temp = Regex.Replace(temp, @"ие", "ее");
                    result.Append(temp + " ");
                }
                else
                    result.Append(i + " ");
            }
            return result.ToString().Trim();
        }
    }
}
