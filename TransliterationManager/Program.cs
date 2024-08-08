using System;
using TransliterationEasy;

public class Program
{
    public static void Main()
    {
        //test 1
        string input = "Київ, Андрій, Яготин, Юрій, Корюківка, Їжакевич, Мар'їне, Щербухи, Гоща";
        string transliterated = Transliteration.Transliterate(input);
        Console.WriteLine(transliterated);
        Console.WriteLine();


        //test 2
        string[] inputs = {
              
                "Згурський",
        };

        foreach (string inputLine in inputs)
        {
            string transliteratedLine = Transliteration.Transliterate(inputLine);
            Console.WriteLine($"{inputLine} -> {transliteratedLine}");
        }
    }
}