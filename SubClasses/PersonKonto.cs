using System;

namespace BankKonsolApplikation.Konton
{
    public class PersonKonto : BankKonto
    {
        public PersonKonto(string kontonummer, string kontoinnehavarensNamn, decimal initialSaldo)
            : base(kontonummer, kontoinnehavarensNamn, initialSaldo) { }
    }
}
