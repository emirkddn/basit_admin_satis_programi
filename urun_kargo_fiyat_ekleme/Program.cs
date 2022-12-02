int pantolon_Fiyat = 100;
int sapka_Fiyat = 100;
int kazak_Fiyat = 100;
Console.WriteLine("Kazak=100TL,Pantolon=70TL,Şapka=40TL");
Console.WriteLine("Mevcut fiyatları değiştirmek istiyor musunuz?(yes/no):");
string cevap = Convert.ToString(Console.ReadLine());
if (cevap=="yes")
{
    Console.WriteLine("Kazağın fiyatını giriniz:");
    kazak_Fiyat = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Pantolonun fiyatını giriniz:");
    pantolon_Fiyat = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Şapkanın fiyatını giriniz:");
    sapka_Fiyat = Convert.ToInt32(Console.ReadLine());
}
else if (cevap=="no")
{
    
}
Console.WriteLine("Ürünler: kazak, pantolon, şapka");
Console.WriteLine("Ürün seçiniz:");
string secim = Convert.ToString(Console.ReadLine());
if (secim == "kazak")
{
    Console.WriteLine("Kazağın fiyatı: " + kazak_Fiyat+"TL");
    Console.WriteLine("Kazak için kargo:" +(kazak_Fiyat/10)+"TL");
    Console.WriteLine("Kazak için ödemeniz gereken:" + (kazak_Fiyat+(kazak_Fiyat / 10))+"TL");
    Console.WriteLine("Onaylıyor musunuz?(yes/no)");
    string yanit = Convert.ToString(Console.ReadLine());
    if (yanit=="yes")
    {
        Console.WriteLine("Siparişiniz alındı.");
        Console.ReadLine();
    }
    else if (yanit=="no")
    {
        Console.WriteLine("Ürün sepetten silindi.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Yanlış komut!");
        Console.ReadLine();
    }
}
else if (secim== "pantolon")
{
    Console.WriteLine("Pantolonun fiyatı: " + pantolon_Fiyat + "TL");
    Console.WriteLine("Pantolon için kargo:");
    Console.WriteLine("Kazak için ödemeniz gereken:" + (pantolon_Fiyat + (pantolon_Fiyat / 10)) + "TL");
    Console.WriteLine("Onaylıyor musunuz?(yes/no)");
    string yanit = Convert.ToString(Console.ReadLine());
    if (yanit == "yes")
    {
        Console.WriteLine("Siparişiniz alındı.");
        Console.ReadLine();
    }
    else if (yanit == "no")
    {
        Console.WriteLine("Ürün sepetten silindi.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Yanlış komut!");
        Console.ReadLine();
    }
}
else if (secim=="şapka")
{
    Console.WriteLine("Şapkanın fiyatı: " + sapka_Fiyat + "TL");
    Console.WriteLine("Şapkanın fiyatı: " + kazak_Fiyat);
    Console.WriteLine("Şapka için ödemeniz gereken:" + (sapka_Fiyat + (sapka_Fiyat / 10)) + "TL");
    Console.WriteLine("Onaylıyor musunuz?(yes/no)");
    string yanit = Convert.ToString(Console.ReadLine());
    if (yanit == "yes")
    {
        Console.WriteLine("Siparişiniz alındı.");
        Console.ReadLine();
    }
    else if (yanit == "no")
    {
        Console.WriteLine("Ürün sepetten silindi.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Yanlış komut!");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Ürün bulunamadı.");
    Console.ReadLine();
}