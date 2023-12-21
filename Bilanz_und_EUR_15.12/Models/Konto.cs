namespace Bilanz_und_EUR_15._12.Models
{
    public class Konto
    {
        public int Id { get; set; }
        public string Kontoname { get; set; }
        public decimal Kontostand { get; set; }
        public bool IstAktiv { get; set; }
        // Weitere Eigenschaften entsprechend den Anforderungen des Kontos

    }
}
