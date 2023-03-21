public class Utente
{
    public string Nome;
    public string Cognome;
    public string Email;
    public string Telefono;
    public string Password;

    public Utente(string nome, string cognome, string email, string telefono,string password)
    {
        Nome = nome;
        Cognome = cognome;
        Email = email;
        Password = password;
        Telefono = telefono;
    }
}
