Console.WriteLine("Lütfen kilonuzu giriniz");
int kilo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen Boyunuz Giriniz");
double boy = Convert.ToDouble(Console.ReadLine());

double bke = kilo / (boy * boy);

if (bke < 18)
{
    Console.WriteLine("Zayıfsınız...");
}
else if (bke >18 &&  bke < 25)
{
    Console.WriteLine("Normalsiniz...");
}
else if (bke >25 && bke < 30)
{
    Console.WriteLine("Obezsiniz...");
}
else if (bke > 30)
{
    Console.WriteLine("Hayvansınız...");
}