using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kitaplık_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamFiyat = 0;
            string secim;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi    **  Yabancı Kitaplar Kategorisi       **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri        **  7-Tuna Kılavuzu: Jules Verne      **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri          **  8-Bir Kuzey Macerası: Jack London **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkaş: Halide Edip **  9-Altıncı Koğuş: Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: O. Atay  **  10-Kumarbaz: Dostoyevski          **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden: H.Yücel **  11-İki Şehrin Hikayesi: C.Dickens **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf: S.Ali      **  12-Vişne Bahçesi: Anton Çehov     **");
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarasını giriniz: ");

            char islemIndex;  //Kullanıcının yapacağı işlem numarasını tutacak değişken.
            islemIndex =Convert.ToChar(Console.ReadLine());

            //Kullanıcının işlem seçimine göre ekrana gelecek menüler aşağıdaki if karar yapılarında belirtilmiştir.

            if (islemIndex == '1') //Kitap Fiyat Sorgulama Menüsü
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını giriniz: ");
                
                string numara; //Kullanıcının seçeceği kitap numarasını tutacak değişken.
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu: 12TL"); break;
                    case "2": Console.Write("Yaban: 14TL"); break;
                    case "3": Console.Write("Sinekli Bakkal: 16TL"); break;
                    case "4": Console.Write("Tehlikeli Oyunlar: 11TL"); break;
                    case "5": Console.Write("Geçtiğim Günlerden: 8TL"); break;
                    case "6": Console.Write("Kuyucaklı Yusuf: 13TL"); break;
                    case "7": Console.Write("Tuna Kılavuzu: 17TL"); break;
                    case "8": Console.Write("BirKuzey Macerası: 4TL"); break;
                    case "9": Console.Write("Altıncı Koğuş: 5TL"); break;
                    case "10": Console.Write("Kumarbaz: 10TL"); break;
                    case "11": Console.Write("İki Şehrin Hikayesi: 13TL"); break;
                    case "12": Console.Write("Vişne Bahçesi: 6TL"); break;
                    default: Console.Write("Bu numarada bir kitap mevcut değil. Lütfen numarayı doğru girin."); break;


                }

            }

            if (islemIndex == '2') //Yeni Okur Kaydı Menüsü
            {
                Console.Write("***** Yeni Okur Kaydı *****");
                Console.WriteLine();
                string isim, soyisim, universite; //Kullanıcının adını, soyadını ve üniversitesini tutacak değişkenler.
                Console.Write("Adınız: ");
                isim=Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyisim = Console.ReadLine();
                Console.Write("Lütfen Üniversitenizi Giriniz: ");
                universite = Console.ReadLine();

                string dosya = @"C:\Users\meral\Desktop\kullanici.txt"; //Oluşturacağımız dosyanın yolunu tutan string değişken.
                StreamWriter sw = new StreamWriter(dosya);  //Dosyamıza yazı yazmak için kullanacağımız yapı.
                sw.WriteLine("Ad :" + isim);
                sw.WriteLine("Soyad :" + soyisim);
                sw.WriteLine("Üniversite: " + universite);
                sw.Close();
                
            }

            if (islemIndex == '3') // Günün Kitabı Menüsü
            {
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün Kitabı: Çalıkuşu  *****");
                Console.WriteLine();
                Console.WriteLine("*************************************");
            }

            if (islemIndex == '4') //Kitap Arşiv Menüsü
            {
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine();
                string arsivYolu;
                FileStream fileS = new FileStream(@"C:\Users\meral\Desktop\Kitap Arşivi.txt",FileMode.Open,FileAccess.Read); //Dosyanın yolunu ve okuma modunu ayarladık.
                StreamReader sr = new StreamReader(fileS); //Akış okuyucumuzu tanımladık.
                string arsivMetni = sr.ReadLine();  
                while (arsivMetni != null)  //Dosyadaki metinleri arsivMetni değişkenimize çekiyoruz.
                {
                    Console.WriteLine(arsivMetni);
                    arsivMetni = sr.ReadLine();
                }
                fileS.Close();
                sr.Close();   //Akışları kapattık ve kaydedilmesini sağladık.
                
                Console.WriteLine();
                Console.WriteLine("*************************************");
                
            }

            if (islemIndex == '5') // Yeni Kitap Satın Alma Menüsü
            {
                for (int i = 1; i <= 100; i++)   //Kullanıcının birden fazla kitap alması için bir döngü açtık.
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitabın Numarası: ");
                    secim = Console.ReadLine();      //Kullanıcının alacağı kitap numarasını tutacak değişken.

                    if (secim == "1")
                    {
                        toplamFiyat = toplamFiyat + 12;
                    }  //Kullanıcı seçimine göre, toplam fiyat değişkeni güncellenecek.
                    else if (secim == "2")
                    {
                        toplamFiyat = toplamFiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplamFiyat = toplamFiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplamFiyat = toplamFiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplamFiyat = toplamFiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplamFiyat = toplamFiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplamFiyat = toplamFiyat + 17;
                    }
                    else if (secim == "8")
                    {
                        toplamFiyat = toplamFiyat + 4;
                    }
                    else if (secim == "9")
                    {
                        toplamFiyat = toplamFiyat + 5;
                    }
                    else if (secim == "10")
                    {
                        toplamFiyat = toplamFiyat + 10;
                    }
                    else if (secim == "11")
                    {
                        toplamFiyat = toplamFiyat + 13;
                    }
                    else if (secim == "12")
                    {
                        toplamFiyat = toplamFiyat + 16;
                    }
                    else
                    Console.WriteLine("Bu numaraya ait bir kitap bulunmamaktadır.");
                        Console.WriteLine();
                        Console.Write("Başka bir kitap almak ister misiniz? E/H");  //Döngü her döndüğünde kullanıcıya başka kitap alıp almayacağını soruyoruz. Hayır cevabı verene kadar bu işlem tekrarlanacak.
                        Console.WriteLine();
                        string cevap = Console.ReadLine();                        

                        if (cevap == "H" || cevap == "h" || cevap == "Hayır" || cevap == "HAYIR" || cevap == "hayır") //Kullanıcı başka kitap almak istemezse, bu kod satırı devreye girecek ve döngü kırılacak.
                        {
                            break;
                        }
                       
                    

                    
                }
                Console.WriteLine("Toplam Tutar: " + toplamFiyat);
            }

            if (islemIndex == '6')  //Tahmin Oyunu Menüsü
            {
                Random rnd = new Random();
                int sayi = rnd.Next(0, 100); //Bilgisayarın rastgele oluşturacağı sayıyı tutacak değişken.
                donus:
                Console.Write("Tahmin ettiğiniz sayıyı giriniz: ");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (girilenSayi < sayi)
                {
                    Console.Clear();
                    Console.WriteLine("Daha büyük bir sayı tahmin etmeniz lazım.");
                    Console.WriteLine();
                    goto donus;
                }
                else if (girilenSayi > sayi)
                {
                    Console.Clear();
                    Console.WriteLine("Daha küçük bir sayı tahmin etmeniz lazım.");
                    Console.WriteLine();
                    goto donus;
                }
                else if (girilenSayi == sayi)
                {
                    Console.Clear();
                    Console.WriteLine("Tebrikler! Doğru tahmin.");
                }


            }


            Console.ReadLine();



        }
    }
}
