using Parametry_kvádru;

double stranaA = int.Parse(Console.ReadLine());
double stranaB = int.Parse(Console.ReadLine());
double stranaC = int.Parse(Console.ReadLine());
Kvádr vysledky = new Kvádr(stranaA, stranaB, stranaC);

Console.WriteLine(vysledky.objem());

Console.WriteLine(vysledky.povrch());

Console.WriteLine(vysledky.telesovaUhlopricka());

Console.WriteLine(vysledky.stenovaUhlopricka());