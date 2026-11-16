 namespace SymulatorGieldy
{
    public class Akcja
    {
        public string Ticker { get; set; }
        public decimal KursBiezacy { get; set; }
        public decimal KursOtwarcia { get; set; }
        public List<Notowanie> HistoriaNotowan { get; set; } = new List<Notowanie>();
    }
}
