// Gerekli namespace'i içe aktarıyoruz
using System.Collections.Generic;

// Ziyaretçilerin isimlerini içeren bir liste oluşturuyoruz
List<string> ziyaretciler = new List<string>() { "Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise", "Hande Yener", "Tarkan", "Funda Arar", "Demet Akalın" };

// Ekrana başlık yazdırıyoruz
Console.WriteLine("** Ziyaretçiler **");

// For döngüsü ile listedeki her ziyaretçiyi yazdırıyoruz
for (int i = 0; i < ziyaretciler.Count; i++)
{
    // i+1 ile 1'den başlayan sıra numarası ekliyoruz
    // ziyaretciler[i] ile listedeki her ismi alıyoruz
    Console.WriteLine(i + 1 + "-" + ziyaretciler[i]);
}

