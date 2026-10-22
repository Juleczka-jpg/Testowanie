using Xunit;

namespace _02_03
{
    public class UnitTest1
    {

        public class Geometria
        {
            [Fact]
            public void PoleProstokata_PoprawneObliczenieDlaDodatnichBokow()
            {
                int bokA = 5;
                int bokB = 10;
                int oczekiwanePole = 50;

                int wynik = Geometria.PoleProstokata(bokA, bokB);

                Assert.Equal(oczekiwanePole, wynik);
            }

            [Fact]
            public void PoleProstokata_PoprawneObliczenieDlaBokowRownychJeden()
            {
                int bokA = 1;
                int bokB = 1;
                int oczekiwanePole = 1;

                int wynik = Geometria.PoleProstokata(bokA, bokB);

                Assert.Equal(oczekiwanePole, wynik);
            }

            [Fact]
            public void PoleProstokata_ZgloszenieWyjatkuGdyJedenZBokowJestZero()
            {
                int bokA = 0;
                int bokB = 5;

                var wyjatek = Assert.Throws<ArgumentException>(() => Geometria.PoleProstokata(bokA, bokB));
                Assert.Equal("Boki muszą być dodatnie.", wyjatek.Message);
            }

            [Fact]
            public void PoleProstokata_ZgloszenieWyjatkuGdyObaBokiSaRowneZero()
            {
                int bokA = 0;
                int bokB = 0;

                var wyjatek = Assert.Throws<ArgumentException>(() => Geometria.PoleProstokata(bokA, bokB));
                Assert.Equal("Boki muszą być dodatnie.", wyjatek.Message);
            }

            public static int PoleProstokata(int bokA, int bokB)
            {
                if (bokA <= 0 || bokB <= 0)
                {
                    throw new ArgumentException("Boki muszą być dodatnie.");
                }

                return bokA * bokB;
            }
        }
    }
}
