namespace BankKonsolApplikation
{
    public abstract class BankKonto
    {
        public string Kontonummer { get; private set; }
        public string KontoinnehavarensNamn { get; private set; }
        public decimal Saldo { get; protected set; }

        protected BankKonto(string kontonummer, string kontoinnehavarensNamn, decimal initialSaldo)
        {
            Kontonummer = kontonummer;
            KontoinnehavarensNamn = kontoinnehavarensNamn;
            Saldo = initialSaldo;
        }

        public virtual void SättIn(decimal belopp)
        {
            if (belopp <= 0)
                throw new ArgumentException("Beloppet måste vara större än 0.");
            Saldo += belopp;
        }

        public virtual void TaUt(decimal belopp)
        {
            if (belopp <= 0)
                throw new ArgumentException("Beloppet måste vara större än 0.");
            if (belopp > Saldo)
                throw new InvalidOperationException("Otillräckligt saldo.");
            Saldo -= belopp;
        }

        public void VisaSaldo()
        {
            Console.WriteLine($"Saldo på konto {Kontonummer}: {Saldo}");
        }

        public void VisaInformation()
        {
            Console.WriteLine($"Konto: {Kontonummer}, Ägare: {KontoinnehavarensNamn}, Saldo: {Saldo}");
        }
    }
}
