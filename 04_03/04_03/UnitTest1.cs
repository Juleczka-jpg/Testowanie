namespace _04_03
{
    public class UnitTest1
    {
        public class Walidator

        {
            public static bool CzyPoprawneHaslo(string haslo)
            {
                if (string.IsNullOrEmpty(haslo))
                {
                    return false;
                }

                return haslo.Length >= 8 && haslo.Length <= 20;
            }

        }

        [Fact]
        public void CzyPoprawneHaslo_DlaTypowegoHasla_PowinnoZwrocicTrue()
        {
            string haslo = "MojeHaslo123";

            bool wynik = Walidator.CzyPoprawneHaslo(haslo);

            Assert.True(wynik);
        }

        [Fact]
        public void CzyPoprawneHaslo_DlaOsmiuZnakow_PowinnoZwrocicTrue()
        {
            string haslo = "Haslo123";

            bool wynik = Walidator.CzyPoprawneHaslo(haslo);

            Assert.True(wynik);
        }

        [Fact]
        public void CzyPoprawneHaslo_DlaSiedemiuZnakow_PowinnoZwrocicFalse()
        {
            string haslo = "Haslo12";

            bool wynik = Walidator.CzyPoprawneHaslo(haslo);

            Assert.False(wynik);
        }

        [Fact]
        public void CzyPoprawneHaslo_DlaPustegoHasla_PowinnoZwrocicFalse()
        {
            string haslo = "";

            bool wynik = Walidator.CzyPoprawneHaslo(haslo);

            Assert.False(wynik);
        }
   
        [Theory]
        [InlineData("12345678")]  
        [InlineData("1234567")]   
        [InlineData("12345678901234567890")] 
        [InlineData("123456789012345678901")] 
        public void CzyPoprawneHaslo_DlaRóżnychDługościHasła_PowinnoZwracaćOczekiwanyWynik(string haslo)
        {
            bool wynik = Walidator.CzyPoprawneHaslo(haslo);

            bool oczekiwanyWynik = haslo.Length >= 8 && haslo.Length <= 20;
            Assert.Equal(oczekiwanyWynik, wynik);
        }
    }
}
