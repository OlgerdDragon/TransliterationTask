using TransliterationEasy;
using Xunit;

namespace TransliterationTests
{
    public class TransliterationTests
    {
        [Theory]
        [InlineData("Алушта", "Alushta")]
        [InlineData("Андрій", "Andrii")]
        [InlineData("Борщагівка", "Borshchahivka")]
        [InlineData("Борисенко", "Borysenko")]
        [InlineData("Вінниця", "Vinnytsia")]
        [InlineData("Володимир", "Volodymyr")]
        [InlineData("Гадяч", "Hadiach")]
        [InlineData("Богдан", "Bohdan")]
        [InlineData("Згурський", "Zghurskyi")]
        [InlineData("Ґалаґан", "Galagan")]
        [InlineData("Ґорґани", "Gorgany")]
        [InlineData("Донецьк", "Donetsk")]
        [InlineData("Дмитро", "Dmytro")]
        [InlineData("Рівне", "Rivne")]
        [InlineData("Олег", "Oleh")]
        [InlineData("Есмань", "Esman")]
        [InlineData("Єнакієве", "Yenakiieve")]
        [InlineData("Гаєвич", "Haievych")]
        [InlineData("Короп'є", "Koropie")]
        [InlineData("Житомир", "Zhytomyr")]
        [InlineData("Жанна", "Zhanna")]
        [InlineData("Жежелів", "Zhezheliv")]
        [InlineData("Закарпаття", "Zakarpattia")]
        [InlineData("Казимирчук", "Kazymyrchuk")]
        [InlineData("Медвин", "Medvyn")]
        [InlineData("Михайленко", "Mykhailenko")]
        [InlineData("Іванків", "Ivankiv")]
        [InlineData("Іващенко", "Ivashchenko")]
        [InlineData("Їжакевич", "Yizhakevych")]
        [InlineData("Кадиївка", "Kadyivka")]
        [InlineData("Мар'їне", "Marine")]
        [InlineData("Йосипівка", "Yosypivka")]
        [InlineData("Стрий", "Stryi")]
        [InlineData("Олексій", "Oleksii")]
        [InlineData("Київ", "Kyiv")]
        [InlineData("Коваленко", "Kovalenko")]
        [InlineData("Лебедин", "Lebedyn")]
        [InlineData("Леонід", "Leonid")]
        [InlineData("Миколаїв", "Mykolaiv")]
        [InlineData("Маринич", "Marynych")]
        [InlineData("Ніжин", "Nizhyn")]
        [InlineData("Наталія", "Nataliia")]
        [InlineData("Одеса", "Odesa")]
        [InlineData("Онищенко", "Onyshchenko")]
        [InlineData("Полтава", "Poltava")]
        [InlineData("Петро", "Petro")]
        [InlineData("Решетилівка", "Reshetylivka")]
        [InlineData("Рибчинський", "Rybchynskyi")]
        [InlineData("Суми", "Sumy")]
        [InlineData("Соломія", "Solomiia")]
        [InlineData("Тернопіль", "Ternopil")]
        [InlineData("Троць", "Trots")]
        [InlineData("Ужгород", "Uzhhorod")]
        [InlineData("Уляна", "Uliana")]
        [InlineData("Фастів", "Fastiv")]
        [InlineData("Філіпчук", "Filipchuk")]
        [InlineData("Харків", "Kharkiv")]
        [InlineData("Христина", "Khrystyna")]
        [InlineData("Біла Церква", "Bila Tserkva")]
        [InlineData("Стеценко", "Stetsenko")]
        [InlineData("Чернівці", "Chernivtsi")]
        [InlineData("Шевченко", "Shevchenko")]
        [InlineData("Шостка", "Shostka")]
        [InlineData("Кишеньки", "Kyshenky")]
        [InlineData("Щербухи", "Shcherbukhy")]
        [InlineData("Гоща", "Hoshcha")]
        [InlineData("Гаращенко", "Harashchenko")]
        [InlineData("Юрій", "Yurii")]
        [InlineData("Корюківка", "Koriukivka")]
        [InlineData("Яготин", "Yahotyn")]
        [InlineData("Ярошенко", "Yaroshenko")]
        [InlineData("Костянтин", "Kostiantyn")]
        [InlineData("Знам'янка", "Znamianka")]
        [InlineData("Феодосія", "Feodosiia")]

        [InlineData("щит", "shchyt")]
        [InlineData("Щит", "Shchyt")]
        [InlineData("ЩИТ", "SHCHYT")]
        [InlineData("ГАЄВИЧ", "HAIEVYCH")]
        [InlineData("єдність", "yednist")]
        public void Transliterate_ValidInput_ReturnsExpectedResult(string input, string expected)
        {
            // Act
            string actual = Transliteration.Transliterate(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Transliterate_InputWithSpecialCharacters_ReturnsTransliteratedResult()
        {
            // Arrange
            string input = "Мар'їне";
            string expected = "Marine";

            // Act
            string actual = Transliteration.Transliterate(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Transliterate_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string input = string.Empty;

            // Act
            string actual = Transliteration.Transliterate(input);

            // Assert
            Assert.Equal(input, actual);
        }
    }
}
