using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");

            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("---- Potakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1245;
            //orangeGram = 2650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine();
            ////Console.WriteLine("Elmanın Toplam Fiyatı :" + appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Elma - " + "Birim Fiyat: " + applePrice + "- Gramaj:" + appleGram + "-toplam tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal - " + "Birim Fiyat: " + orangePrice + "- Gramaj:" + orangeGram + "-toplam tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + "- Gramaj:" + strawberryGram + "-toplam tutar:" + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates - " + "Birim Fiyat: " + potatoPrice + "- Gramaj:" + potatoGram + "-toplam tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + "- Gramaj:" + tomatoGram + "-toplam tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL";

            #endregion

            #region Char değişkenler

            //ABCDEFGH
            //DEF..
            //TOPLANTI SAAT 20 DE

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu T.C Kimlik NO.: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.Write("------------------------------------------------------------: ");
            //Console.WriteLine("Yolcu T.C. Kimlik NO.: " + passengerIdentityNumber  + "- Yolcu Ad Soyad" + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity +" " + passengerAge );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler


            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write(" Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write(" Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write(" Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write(" Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);



            #endregion

            #region  Klavyeden Ondalıklı Sayı İşlemleri

            //Double exam1, exam2, exam3, result;

            //Console.Write(" lütfen 1. Sınav notunu giriniz: ");
            //exam1 = Double.Parse(Console.ReadLine());
            //Console.Write(" lütfen 2. Sınav notunu giriniz: ");
            //exam2 = Double.Parse(Console.ReadLine());
            //Console.Write(" lütfen 3. Sınav notunu giriniz: ");
            //exam3 = Double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;


            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);



            #endregion

            #region klavyeden karakter girişleri
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion



            Console.Read();

        }
    }
}
