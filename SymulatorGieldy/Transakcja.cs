namespace SymulatorGieldy
{
    public class Transakcja
    {
        public int Id { get; set; }
        public decimal CenaRealizacji { get; set; }
        public int LiczbaSztuk { get; set; }
        public decimal Prowizja { get; set; }
        public DateTime CzasRealizacji { get; set; }
        public Zlecenie ZlecenieKupna { get; set; }
        public Zlecenie ZlecenieSprzedazy { get; set; }
    }
}
