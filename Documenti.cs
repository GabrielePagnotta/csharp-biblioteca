public class Documento
{
    public string Codice { get; set; } = string.Empty;
    public string Titolo { get; set; } = string.Empty; 
    public int Anno { get; set; }
    public string ? Settore { get; set; } = string.Empty;
    public string ? Scaffale { get; set; } = string.Empty;
    public string ? Autore { get; set; } = string.Empty; 

    public Documento(string codice, string titolo)
    {
        Codice = codice;
        Titolo = titolo;
       
    }

   
}


public class Libro:Documento
{
    public int ? Numeropagine { get; set; }
    public Libro(string codice, string titolo) : base(codice, titolo)
    {
       
    }


    

}

public class Dvd : Documento
{
    public int ? Durata { get; set; }
    public Dvd(string codice, string titolo) : base(codice, titolo)
    {
        
    }


   
}

