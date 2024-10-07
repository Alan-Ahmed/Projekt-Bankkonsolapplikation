using System;

namespace BankKonsolApplikation.Konton
{
    public class Sparkonto : BankKonto
    {
        public Sparkonto(string kontonummer, string kontoinnehavarensNamn, decimal initialSaldo)
            : base(kontonummer, kontoinnehavarensNamn, initialSaldo) { }
    }
}
