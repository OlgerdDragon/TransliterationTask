using TransliterationEasy;
using Xunit;

namespace TransliterationTests
{
    public class TransliterationTests
    {
        [Theory]
        [InlineData("Київ", "Kyiv")]
        [InlineData("Андрій", "Andrii")]
        [InlineData("Яготин", "Yahotyn")]
        [InlineData("Юрій", "Iurii")]
        [InlineData("Корюківка", "Koriukivka")]
        [InlineData("Їжакевич", "Izhakevych")]
        [InlineData("Мар'їне", "Marine")]
        [InlineData("Щербухи", "Shcherbukhy")]
        [InlineData("Гоща", "Hoshcha")]
        [InlineData("Єнакієве", "Yenakiieve")]
        [InlineData("Ґорґани", "Gorgany")]
        [InlineData("Ніжин", "Nizhyn")]
        [InlineData("Біла Церква", "Bila Tserkva")]

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
