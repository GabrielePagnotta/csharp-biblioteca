public class Libreria
{
    public List<string> ListaUtenti = new List<string>();
    public List<string> ListaDocumenti = new List<string>();
    public List<string> ListaPrestiti = new List<string>();

    public Libreria(List<string> listaUtenti, List<string> listaDocumenti, List<string> listaPrestiti)
    {
        ListaUtenti = listaUtenti;
        ListaDocumenti = listaDocumenti;
        ListaPrestiti = listaPrestiti;
    }
}