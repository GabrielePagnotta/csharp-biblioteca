using System.Runtime.CompilerServices;

Utente nuovoUtente = new Utente("","","","","");
Console.WriteLine("sei registrato? Y/N");

char ask =Convert.ToChar( Console.ReadLine());


if (ask == 'N')
{
    
Console.WriteLine("inserisci un nome");
nuovoUtente.Nome = Console.ReadLine();


Console.WriteLine("inserisci un cognome");
nuovoUtente.Cognome = Console.ReadLine();


Console.WriteLine("inserisci una email");
nuovoUtente.Email = Console.ReadLine();

Console.WriteLine("inserisci un numero di telefono");
nuovoUtente.Telefono = Console.ReadLine();

Console.WriteLine("inserisci una password");
nuovoUtente.Password = Console.ReadLine();

Console.WriteLine("registrazione effettuata con successo");


Console.WriteLine(nuovoUtente.ToString());
}
else if(ask == 'Y')
{
    Console.WriteLine("accesso in corso");
}
else
{
    Console.WriteLine("inserisci un input valido");
}






