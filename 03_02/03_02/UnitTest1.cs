namespace _03_02
{
    public class UnitTest1
    {
        public static class WalidatorZestawow
        {
            public static bool CzyPoprawnaLiczba(int liczbaZestawow)
            {
                return liczbaZestawow >= 1 && liczbaZestawow <= 100;
            }
        }

        public class WalidatorZestawowTests
        {
            [Theory]
            [InlineData(1, true)]  
            [InlineData(50, true)]  
            [InlineData(100, true)] 

            public void CzyPoprawnaLiczba_DlaPoprawnychWartosciZwracaTrue(int liczbaZestawow, bool oczekiwanyWynik)
            {
                bool wynik = WalidatorZestawow.CzyPoprawnaLiczba(liczbaZestawow);

                Assert.Equal(oczekiwanyWynik, wynik);
            }

            [Theory]
            [InlineData(0, false)]   
            [InlineData(-1, false)]  
            [InlineData(-100, false)]
            [InlineData(101, false)]

            public void CzyPoprawnaLiczba_DlaNiepoprawnychWartosciZwracaFalse(int liczbaZestawow, bool oczekiwanyWynik)
            {
                bool wynik = WalidatorZestawow.CzyPoprawnaLiczba(liczbaZestawow);

                Assert.Equal(oczekiwanyWynik, wynik);
            }
        }
    }
}
