// See https://aka.ms/new-console-template for more information
using CsharpShop2;

string NomeProdotto = "Carne";
string DiscrezioneProdotto = "cane di mucca";
int PrezzoProdotto = 7;
double Iva = 0.22;





Prodotto InputUtente = new Prodotto(NomeProdotto, DiscrezioneProdotto, PrezzoProdotto, Iva);


InputUtente.StampaDatiProdotto();