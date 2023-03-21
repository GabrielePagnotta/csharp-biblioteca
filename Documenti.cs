

public class Documenti
{
    public int Codice { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public int Scaffale { get; set; }
    public string Autore { get; set; }

    public Documenti(int codice, string titolo, int anno, string settore, int scaffale, string autore)
    {
        Codice = codice;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Scaffale = scaffale;
        Autore = autore;

    }

   
}


public class Libro:Documenti
{
    public Libro(int codice, string titolo, int anno, string settore, int scaffale, string autore) : base(codice, titolo, anno, settore, scaffale, autore)
    {
    }

    public int Numeropagine { get; set; }
    

}

public class Dvd : Documenti
{
    public double durata;

    public Dvd(int codice, string titolo, int anno, string settore, int scaffale, string autore) : base(codice, titolo, anno, settore, scaffale, autore)
    {
    }
}

