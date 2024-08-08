using System.Text;

namespace TransliterationEasy
{
    public static class Transliteration
    {
        private static readonly Dictionary<string, string> translitTable = new Dictionary<string, string>
        {
            {"А", "A"}, {"а", "a"}, 
            {"Б", "B"}, {"б", "b"}, 
            {"В", "V"}, {"в", "v"},
            {"Г", "H"}, {"г", "h"}, 
            {"Ґ", "G"}, {"ґ", "g"}, 
            {"Д", "D"}, {"д", "d"},
            {"Е", "E"}, {"е", "e"}, 
            {"Є", "Ye"}, {"є", "ie"}, 
            {"Ж", "Zh"}, {"ж", "zh"},
            {"З", "Z"}, {"з", "z"}, 
            {"И", "Y"}, {"и", "y"}, 
            {"І", "I"}, {"і", "i"},
            {"Ї", "Yi"}, {"ї", "i"}, 
            {"Й", "Y"}, {"й", "i"}, 
            {"К", "K"}, {"к", "k"},
            {"Л", "L"}, {"л", "l"}, 
            {"М", "M"}, {"м", "m"}, 
            {"Н", "N"}, {"н", "n"},
            {"О", "O"}, {"о", "o"}, 
            {"П", "P"}, {"п", "p"}, 
            {"Р", "R"}, {"р", "r"},
            {"С", "S"}, {"с", "s"}, 
            {"Т", "T"}, {"т", "t"}, 
            {"У", "U"}, {"у", "u"},
            {"Ф", "F"}, {"ф", "f"}, 
            {"Х", "Kh"}, {"х", "kh"}, 
            {"Ц", "Ts"}, {"ц", "ts"},
            {"Ч", "Ch"}, {"ч", "ch"}, 
            {"Ш", "Sh"}, {"ш", "sh"}, 
            {"Щ", "Shch"}, {"щ", "shch"},
            {"Ю", "Yu"}, {"ю", "iu"}, 
            {"Я", "Ya"}, {"я", "ia"},
            
            {"'", ""}, {"’", ""}, {"ь", ""}
        };

        public static string Transliterate(string input)
        {
            bool allUpperCase = input.ToUpper() == input;
            if (allUpperCase)
            {
                input = input.ToLower();
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1 && (input[i] == 'з') && input[i + 1] == 'г')
                {
                    result.Append("zgh");
                    i++; 
                }
                if (i < input.Length - 1 && (input[i] == 'З') && input[i + 1] == 'г')
                {
                    result.Append("Zgh");
                    i++;
                }
                else
                {
                    string currentChar = input[i].ToString();
                    if (currentChar == "є" && i == 0) result.Append("ye");
                    else if (currentChar == "ї" && i == 0) result.Append("yi");
                    else if (currentChar == "й" && i == 0) result.Append("y");
                    else if (currentChar == "ю" && i == 0) result.Append("yu");
                    else if (currentChar == "я" && i == 0) result.Append("ya");
                    else if (translitTable.ContainsKey(currentChar))
                    {
                        result.Append(translitTable[currentChar]);
                    }
                    else
                    {
                        result.Append(currentChar);
                    }
                }
            }

            return allUpperCase ? result.ToString() : result.ToString().ToUpper();
        }
    }
}
