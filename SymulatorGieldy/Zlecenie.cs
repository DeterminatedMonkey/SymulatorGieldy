namespace SymulatorGieldy
{
    public class Zlecenie
    {
        public int Id { get; set; }
        public TypZlecenia Typ { get; set; }
        public RodzajZlecenia Rodzaj { get; set; }
        public StatusZlecenia Status { get; set; }
        public int LiczbaSztuk { get; set; }
        public decimal CenaLimitu { get; set; }
        public DateTime CzasZlozenia { get; set; }
        public Akcja Akcja { get; set; }
        public decimal SredniaKroczaca(List<decimal> notowania)
        {
            throw new NotImplementedException();
        }
        public bool Wskaznik(Akcja kursBiezacy, TypZlecenia typ)
        {
            throw new NotImplementedException();
        }
    }
}
