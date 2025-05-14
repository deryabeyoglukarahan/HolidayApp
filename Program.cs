// Tatil planlamayı tekrar başlatmak için döngü
while (true)
{
    Console.WriteLine("Yol Arkadaşı : Tatil Uygulaması");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Size sunulan 3 adet lokasyon mevcuttur:");
    Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");
    Console.WriteLine("-------------------------------");

    string location = ""; //lokasyon bilgisini tutan değişken
    int packagePrice = 0; //paket fiyat bilgisini tutan değişken

    //Lokasyon seçimi: Kullanıcıdan geçerli lokasyon girilene kadar tekrar sorar
    while (true)
    {
        Console.Write("Gitmek istediğiniz lokasyonun ismini giriniz: ");
        string locationName = Console.ReadLine().ToLower(); //Girilen lokasyonun büyük-küçük harf duyarlılığını ortadan kaldırmak için ToLower() kullanıyoruz.

        if (locationName == "bodrum")
        {
            location = "Bodrum";
            packagePrice = 4000;
            break; //geçerli seçim yapılırsa döngüden çıkmak için break komutunu kullanıyoruz.
        }
        else if (locationName == "marmaris")
        {
            location = "Marmaris";
            packagePrice = 3000;
            break; //geçerli seçim yapılırsa döngüden çıkmak için break komutunu kullanıyoruz.
        }
        else if (locationName == "çeşme" || locationName == "cesme")
        {
            location = "Çeşme";
            packagePrice = 5000;
            break; //geçerli seçim yapılırsa döngüden çıkmak için break komutunu kullanıyoruz.
        }
        else
        {
            Console.WriteLine("Hatalı giriş! Lütfen sadece Bodrum, Marmaris veya Çeşme yazınız.");
        }
    }

    // Kişi sayısını kullanıcıdan alıyoruz.
    Console.Write("Kaç kişi için tatil planlamak istiyorsunuz? ");
    int person = Convert.ToInt32(Console.ReadLine());

    // // Lokasyon hakkında bilgi verilir
    Console.WriteLine($"\nSeçilen Lokasyon: {location}");
    Console.WriteLine($"{location} tatilinizde denizin ve güneşin tadını çıkaracaksınız.\n");

    int transportCost = 0; // Ulaşım bilgilerini tutan değişken
    // Ulaşım seçimi : Kullanıcıdan geçerli ulaşım seçimi alınır
    while (true)
    {
        Console.WriteLine("Ulaşım tercihinizi seçiniz:");
        Console.WriteLine("1 - Kara yolu (Kişi başı 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı 4000 TL)");
        Console.Write("Seçiminiz (1 veya 2 yazarak cevaplayınız): ");
        string chooseTransport = Console.ReadLine();

        if (chooseTransport == "1")
        {
            transportCost = 1500;
            break; //geçerli seçim yapılırsa döngüden çıkmak için break komutunu kullanıyoruz.
        }
        else if (chooseTransport == "2")
        {
            transportCost = 4000;
            break; //geçerli seçim yapılırsa döngüden çıkmak için break komutunu kullanıyoruz.
        }
        else
        {
            Console.WriteLine("Hatalı seçim! Lütfen sadece 1 ya da 2 giriniz.");
        }
    }

    // Toplam maliyet hesaplanır ve ekrana yazdırılır
    int totalPrice = (packagePrice + transportCost) * person;
    Console.WriteLine($"\nToplam tutar: {totalPrice} TL ({person} kişi için)");

    // Kullanıcıya yeniden tatil planlamak isteyip istemediği sorulur
    Console.Write("\nBaşka bir tatil planlamak ister misiniz? (evet / hayır): ");
    string again = Console.ReadLine().ToLower();

    if (again != "evet")
    {
        Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler, iyi tatiller!");
        break; // Kullanıcı başka bir tatil planlamak istemiyorsa döngü biter, uygulama sona erer
    }

    Console.Clear(); // Konsol ekranını temizleyip yeniden tatil planlamak için uygulamayı baştan başlatır.
}


