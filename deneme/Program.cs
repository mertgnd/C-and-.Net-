// See https://aka.ms/new-console-template for more information


string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisKontrol = false;
double dolarinDunkuDegeri = 7.37;
double dolarinBugunkuDegeri = 7.36;

if (dolarinDunkuDegeri > dolarinBugunkuDegeri)
{
    Console.WriteLine("Azalış Oku Göster!\n");
}
else if (dolarinBugunkuDegeri==dolarinDunkuDegeri)
{
    Console.WriteLine("Eşitlik Oku Göster!\n");
}
else
{
    Console.WriteLine("Artış Oku Göster!\n");
}

if (sistemeGirisKontrol == true)
{
    Console.WriteLine("Kullanıcı Sisteme Başarıyla Giriş Yaptı!");
}
else
{
    Console.WriteLine("Kullanıcı Sisteme Başarıyla giriş Yapamadı!");
}

Console.WriteLine(sistemeGirisKontrol);
Console.WriteLine(faizOrani);
Console.WriteLine(ogrenciSayisi);
Console.WriteLine(kategoriEtiketi);
