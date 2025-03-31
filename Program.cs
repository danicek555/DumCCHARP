// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadej delku zdi v metrech:");
double delkaZdi = Convert.ToInt32(Console.ReadLine());

if (delkaZdi < 5 || delkaZdi > 100)
{
    Console.WriteLine("Příště zadej delku zdi mezi 5 a 100 metry!");
    return;  
}

double mistnosti = delkaZdi / 3;    
double tlouskaZdi = delkaZdi / 10;
double delkaSteny = (delkaZdi * 8) / 10;

double obytnyProstor = delkaSteny * delkaSteny;
double dvere = mistnosti * 2;
double zasuvky = (2 * mistnosti) + (mistnosti / 2) + 1;
double okna = (tlouskaZdi + 1) * (tlouskaZdi + 1)  + dvere + 1;




double poplatky = 50000;
double náročnost = 0.01 * (mistnosti + 2);
double naklady = (obytnyProstor * 18000) + poplatky * (1 + náročnost);


Console.WriteLine("Dum se zdí o délce " + delkaZdi + " má parametry:");
Console.WriteLine("Počet místností: " + mistnosti);
Console.WriteLine("Tloušťka stěny: " + tlouskaZdi + "m");
Console.WriteLine("Délka stěny: " + delkaSteny + "m");
Console.WriteLine("Obytný prostor:" + obytnyProstor + "m2");
Console.WriteLine("Počet dveří: " + dvere);
Console.WriteLine("Počet zásuvek: " + zasuvky);
Console.WriteLine("Počet oken: " + okna);
Console.WriteLine("Tvoje náklady jsou: " + naklady);
