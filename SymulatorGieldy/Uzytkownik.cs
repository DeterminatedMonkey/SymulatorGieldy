namespace SymulatorGieldy
{
    public class Uzytkownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public List<KontoMaklerskie> Konta { get; set; } = new List<KontoMaklerskie>();
        public void ZalozKonto(string numer)
        {
            throw new NotImplementedException();
        }
        public void Zaloguj()
        {
            throw new NotImplementedException();
        }
        public void Wyloguj()
        {
            throw new NotImplementedException();
        }
    }
}
