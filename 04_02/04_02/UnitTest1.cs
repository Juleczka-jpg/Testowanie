using Xunit;


namespace _04_02
{
    public class UnitTest1
    {

        public class Konto

        {
            public static decimal Wplac(decimal saldo, decimal kwota)
            {
                if (kwota <= 0)
                {
                    throw new ArgumentException("Kwota wpłaty musi być dodatnia.");
                }

                return saldo + kwota;
            }
        }

        [Fact]
        public void Wplac_DlaPoprawnejKwoty_ZwracaNoweSaldo()
        {
            decimal poczatkoweSaldo = 100.00m;
            decimal kwotaWplaty = 50.00m;
            decimal oczekiwaneSaldo = 150.00m;

            decimal wynik = Konto.Wplac(poczatkoweSaldo, kwotaWplaty);

            Assert.Equal(oczekiwaneSaldo, wynik);
        }

        [Fact]
        public void Wplac_DlaKwotyBrzegowej001_ZwracaNoweSaldo()
        {
            decimal poczatkoweSaldo = 0.00m;
            decimal kwotaWplaty = 0.01m;
            decimal oczekiwaneSaldo = 0.01m;

            decimal wynik = Konto.Wplac(poczatkoweSaldo, kwotaWplaty);

            Assert.Equal(oczekiwaneSaldo, wynik);
        }

        [Fact]
        public void Wplac_DlaKwotyZero_ThrowsArgumentException()
        {
            decimal poczatkoweSaldo = 100.00m;
            decimal kwotaWplaty = 0.00m;

            var wyjatek = Assert.Throws<ArgumentException>(() => Konto.Wplac(poczatkoweSaldo, kwotaWplaty));
            Assert.Equal("Kwota wpłaty musi być dodatnia.", wyjatek.Message);
        }
    }
}
