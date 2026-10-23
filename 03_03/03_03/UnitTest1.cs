using Xunit;

namespace _03_03
{
    // Klasa zawierająca metodę Opisz
    public static class Oceny
    {
        public static string Opisz(int ocena)
        {
            if (ocena < 1 || ocena > 6)
            {
                return "ocena nieprawidlowa";
            }

            if (ocena <= 2)
            {
                return "ocena niska";
            }

            if (ocena <= 4)
            {
                return "ocena srednia";
            }

            return "ocena wysoka";
        }
    }

    public class OcenyTests
    {
        [Theory]
        [InlineData(1, "ocena niska")]
        [InlineData(2, "ocena niska")]
        [InlineData(3, "ocena srednia")]
        [InlineData(4, "ocena srednia")]
        [InlineData(5, "ocena wysoka")]
        [InlineData(6, "ocena wysoka")]
        [InlineData(0, "ocena nieprawidlowa")]
        [InlineData(7, "ocena nieprawidlowa")]
        [InlineData(-1, "ocena nieprawidlowa")]
        [InlineData(100, "ocena nieprawidlowa")]
        public void Opisz_DlaDanejOcenyZwracaOdpowiedniOpis(int ocena, string oczekiwanyOpis)
        {
            string wynik = Oceny.Opisz(ocena);

            Assert.Equal(oczekiwanyOpis, wynik);
        }
    }
}