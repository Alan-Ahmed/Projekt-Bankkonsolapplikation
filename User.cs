using BankKonsolApplikation.Konton;

namespace BankKonsolApplikation
{
    public class Bank
    {
        public PersonKonto Personkonto { get; private set; }
        public Sparkonto Sparkonto { get; private set; }
        public Investeringskonto Investeringskonto { get; private set; }

        public Bank()
        {
            // Skapa fasta konton med enklare namn och nummer
            Personkonto = new PersonKonto("001", "Alan", 1000);
            Sparkonto = new Sparkonto("002", "Nemo", 2000);
            Investeringskonto = new Investeringskonto("003", "Balen", 3000);
        }

        public void VisaAllaKonton()
        {
            Personkonto.VisaInformation();
            Sparkonto.VisaInformation();
            Investeringskonto.VisaInformation();
        }
    }
}
