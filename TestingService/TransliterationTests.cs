using TransliterationEasy;
using Xunit;

namespace TransliterationTests
{
    public class TransliterationTests
    {
        [Theory]
        [InlineData("���", "Kyiv")]
        [InlineData("�����", "Andrii")]
        [InlineData("������", "Yahotyn")]
        [InlineData("���", "Iurii")]
        [InlineData("��������", "Koriukivka")]
        [InlineData("��������", "Izhakevych")]
        [InlineData("���'���", "Marine")]
        [InlineData("�������", "Shcherbukhy")]
        [InlineData("����", "Hoshcha")]
        [InlineData("���곺��", "Yenakiieve")]
        [InlineData("������", "Gorgany")]
        [InlineData("ͳ���", "Nizhyn")]
        [InlineData("���� ������", "Bila Tserkva")]

        [InlineData("���", "shchyt")]
        [InlineData("���", "Shchyt")]
        [InlineData("���", "SHCHYT")]
        [InlineData("������", "HAIEVYCH")]
        [InlineData("������", "yednist")]
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
            string input = "���'���";
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
