using csharp_biblioteca;

public class Libreria
{
    public List<Utente> ListaUtenti = new ();
    public List<Documento> ListaDocumenti = new ();
    public List<Prestito> ListaPrestiti = new ();

    public void AggiungiDocumento(Documento documento) => ListaDocumenti.Add(documento);
    public void AggiungiUtente(Utente utente) => ListaUtenti.Add(utente);
    public void AggiungiUtente(Prestito prestito) => ListaPrestiti.Add(prestito);

    public Documento? CercaDocumentoPerCodice(string codice) => ListaDocumenti.FirstOrDefault(documento => documento.Codice == codice);
    public IEnumerable<Documento> CercaDocumentoPerTitolo(string titolo) => ListaDocumenti.Where(documento => documento.Titolo == titolo);

    public IEnumerable<Prestito> CercaPrestito(string nomeUtente, string cognomeUtente) =>
            ListaPrestiti.Where(prestito => prestito.Utente.Nome == nomeUtente && prestito.Utente.Cognome == cognomeUtente);
}