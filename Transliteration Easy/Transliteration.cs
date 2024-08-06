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
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string currentChar = input[i].ToString();

                if (currentChar == "Є" && i == 0) result.Append("Ye");
                else if (currentChar == "є" && i > 0) result.Append("ie");
                else if (currentChar == "Ї" && i == 0) result.Append("Yi");
                else if (currentChar == "ї" && i > 0) result.Append("i");
                else if (currentChar == "Й" && i == 0) result.Append("Y");
                else if (currentChar == "й" && i > 0) result.Append("i");
                else if (currentChar == "Ю" && i == 0) result.Append("Yu");
                else if (currentChar == "ю" && i > 0) result.Append("iu");
                else if (currentChar == "Я" && i == 0) result.Append("Ya");
                else if (currentChar == "я" && i > 0) result.Append("ia");
                else if (translitTable.ContainsKey(currentChar))
                {
                    result.Append(translitTable[currentChar]);
                }
                else
                {
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }
    }
}
