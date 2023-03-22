using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        public Prestito(Documento documento, Utente utente)
        {
            Documento = documento;
            Utente = utente;
        }

        public DateTime ? InizioPrestito { get; set; }
        public DateTime ? FinePrestito { get; set; }
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }
    }
}
