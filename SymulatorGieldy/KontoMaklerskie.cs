namespace SymulatorGieldy
{
    public class KontoMaklerskie
    {
        public string Numer { get; set; }
        public decimal Saldo { get; set; }
        public List<Pozycja> Pozycje { get; set; } = new List<Pozycja>();
        public List<Zlecenie> Zlecenia { get; set; } = new List<Zlecenie>();
        public void Wplac(decimal kwota)
        {
            throw new NotImplementedException();
        }
        public void Wyplac(decimal kwota)
        {
            throw new NotImplementedException();
        }
        public void ZablokujSrodki(decimal kwota)
        {
            throw new NotImplementedException();
        }
    }
}
