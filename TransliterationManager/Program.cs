using System;
using TransliterationEasy;

public class Program
{
    public static void Main()
    {
        string input = "Київ, Андрій, Яготин, Юрій, Корюківка, Їжакевич, Мар'їне, Щербухи, Гоща";
        string transliterated = Transliteration.Transliterate(input);
        Console.WriteLine(transliterated);
    }
}