
var res = CercaDocumentoPerCodice_TrovaPerCodice();
printTestResult(nameof(CercaDocumentoPerCodice_TrovaPerCodice), res);

void printTestResult(string testCase, bool ok)
{
    Console.WriteLine($"testing: {testCase}");
    Console.WriteLine(ok ? "passed :)" : "failed :(");
}

bool CercaDocumentoPerCodice_TrovaPerCodice()
{
    var biblioteca = new Libreria();
    var testDoc = new Documento("0001", "peppa pig");
    biblioteca.AggiungiDocumento(testDoc);
    biblioteca.AggiungiDocumento(new Documento("0002", "boolean"));
    biblioteca.AggiungiDocumento(new Documento("0003", "shrek2"));

    var risultato = biblioteca.CercaDocumentoPerCodice("0001");

    return risultato == testDoc;
   }