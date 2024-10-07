using System;

namespace BankKonsolApplikation.Konton
{
    public class Investeringskonto : BankKonto
    {
        public Investeringskonto(string kontonummer, string kontoinnehavarensNamn, decimal initialSaldo)
            : base(kontonummer, kontoinnehavarensNamn, initialSaldo) { }
    }
}
