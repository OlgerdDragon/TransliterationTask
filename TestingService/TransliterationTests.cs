using TransliterationEasy;
using Xunit;

namespace TransliterationTests
{
    public class TransliterationTests
    {
        [Theory]
        [InlineData("������", "Alushta")]
        [InlineData("�����", "Andrii")]
        [InlineData("���������", "Borshchahivka")]
        [InlineData("���������", "Borysenko")]
        [InlineData("³�����", "Vinnytsia")]
        [InlineData("���������", "Volodymyr")]
        [InlineData("�����", "Hadiach")]
        [InlineData("������", "Bohdan")]
        [InlineData("���������", "Zghurskyi")]
        [InlineData("������", "Galagan")]
        [InlineData("������", "Gorgany")]
        [InlineData("�������", "Donetsk")]
        [InlineData("������", "Dmytro")]
        [InlineData("г���", "Rivne")]
        [InlineData("����", "Oleh")]
        [InlineData("������", "Esman")]
        [InlineData("���곺��", "Yenakiieve")]
        [InlineData("�����", "Haievych")]
        [InlineData("�����'�", "Koropie")]
        [InlineData("�������", "Zhytomyr")]
        [InlineData("�����", "Zhanna")]
        [InlineData("������", "Zhezheliv")]
        [InlineData("����������", "Zakarpattia")]
        [InlineData("����������", "Kazymyrchuk")]
        [InlineData("������", "Medvyn")]
        [InlineData("����������", "Mykhailenko")]
        [InlineData("������", "Ivankiv")]
        [InlineData("��������", "Ivashchenko")]
        [InlineData("��������", "Yizhakevych")]
        [InlineData("�������", "Kadyivka")]
        [InlineData("���'���", "Marine")]
        [InlineData("��������", "Yosypivka")]
        [InlineData("�����", "Stryi")]
        [InlineData("������", "Oleksii")]
        [InlineData("���", "Kyiv")]
        [InlineData("���������", "Kovalenko")]
        [InlineData("�������", "Lebedyn")]
        [InlineData("�����", "Leonid")]
        [InlineData("�������", "Mykolaiv")]
        [InlineData("�������", "Marynych")]
        [InlineData("ͳ���", "Nizhyn")]
        [InlineData("������", "Nataliia")]
        [InlineData("�����", "Odesa")]
        [InlineData("��������", "Onyshchenko")]
        [InlineData("�������", "Poltava")]
        [InlineData("�����", "Petro")]
        [InlineData("����������", "Reshetylivka")]
        [InlineData("�����������", "Rybchynskyi")]
        [InlineData("����", "Sumy")]
        [InlineData("������", "Solomiia")]
        [InlineData("��������", "Ternopil")]
        [InlineData("�����", "Trots")]
        [InlineData("�������", "Uzhhorod")]
        [InlineData("�����", "Uliana")]
        [InlineData("�����", "Fastiv")]
        [InlineData("Գ�����", "Filipchuk")]
        [InlineData("�����", "Kharkiv")]
        [InlineData("��������", "Khrystyna")]
        [InlineData("���� ������", "Bila Tserkva")]
        [InlineData("��������", "Stetsenko")]
        [InlineData("�������", "Chernivtsi")]
        [InlineData("��������", "Shevchenko")]
        [InlineData("������", "Shostka")]
        [InlineData("��������", "Kyshenky")]
        [InlineData("�������", "Shcherbukhy")]
        [InlineData("����", "Hoshcha")]
        [InlineData("���������", "Harashchenko")]
        [InlineData("���", "Yurii")]
        [InlineData("��������", "Koriukivka")]
        [InlineData("������", "Yahotyn")]
        [InlineData("��������", "Yaroshenko")]
        [InlineData("���������", "Kostiantyn")]
        [InlineData("����'����", "Znamianka")]
        [InlineData("�������", "Feodosiia")]

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
