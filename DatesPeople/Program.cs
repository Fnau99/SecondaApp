// See https://aka.ms/new-console-template for more information
using DatesPeople;

Console.WriteLine("Hello, World!");

//inizializzo la classe persona
DatesPeople.Person P;
P = new DatesPeople.Person("Nawfal", "Fikri", "M", "RE", new DateTime(1999,10,29));

//Richiamo il metodo ShowAge
P.ShowAge();
P.ShowFiscalCode();