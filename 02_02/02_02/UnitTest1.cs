namespace _02_02
{
    public class UnitTest1
    {
        [Fact]
        public void CzyDodatnia_ZwracaTrue_DlaLiczbyDodatniej()
        {
            // Arrange
            int liczba = 5;

            // Act
            bool wynik = Liczby.CzyDodatnia(liczba);

            // Assert
            Assert.True(wynik);
        }

        [Fact]
        public void CzyDodatnia_ZwracaFalse_DlaLiczbyUjemnej()
        {
            // Arrange
            int liczba = -3;

            // Act
            bool wynik = Liczby.CzyDodatnia(liczba);

            // Assert
            Assert.False(wynik);
        }

        [Fact]
        public void CzyDodatnia_ZwracaFalse_DlaZera()
        {
            // Arrange
            int liczba = 0;

            // Act
            bool wynik = Liczby.CzyDodatnia(liczba);

            // Assert
            Assert.False(wynik);
        }
        
        public static class Liczby
        {
            public static bool CzyDodatnia(int liczba)
            {
                return liczba > 0;
            }

        }

    }
}
