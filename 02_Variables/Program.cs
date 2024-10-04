using Microsoft.CSharp;
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
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("Fiyat listesi");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.25;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 7.65;
            //tomatoPrice = 6.88;
            //Console.WriteLine("- Elma Birim Fiyatı " + applePrice);
            //Console.WriteLine("- Portakal Birim Fiyatı " + orangePrice);
            //Console.WriteLine("- Çilek Birim Fiyatı " + strawberryPrice);
            //Console.WriteLine("- Patates Birim Fiyatı " + potatoPrice);
            //Console.WriteLine("- Domates Birim Fiyatı " + tomatoPrice);


            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.451;
            //double appleTotalPrice = applePrice * appleGram;
            //Console.WriteLine( "Elmanın Toplam Fiyatı:"+appleTotalPrice);
            #endregion
            #region Char Değişkenler
            //charlar tek tırnaklar
            //char symbol= 'A';
            //Console.WriteLine(symbol);

            #endregion
            #region Klavyeden Veri Girişleri
            //Console.WriteLine("*****CSharpCodeProvider yolcu bilgiler*****");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIDNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName =Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu yaşı");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Kimlik no");
            //passengerIDNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Yolcu kimlik no: " + passengerIDNumber + " -Yolcu Ad Soyad " + passengerName + " " + passengerSurname + " " + passengerDistrict + " " + passengerCity + " " + passengerAge);  


            #endregion
            #region Tam sayı girişleri ve Dönüşümler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount,   chairCount, tvCount;

            //Console.Write("Lütfen Kaç ayakkabı aldığınızı giriniz");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Kaç sandalye aldığınızı giriniz");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Kaç bilgisayar aldığınızı giriniz");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Kaç Tv aldığınızı giriniz");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoeCount*shoePrice+computerCount*computerPrice+chairPrice*chairCount+tvCount*tvPrice;

            //Console.Write("Toplam Ödeme Miktarınız: " + totalPrice);


            #endregion
            #region Klavyeden Ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen Birinci Sınav Notu Giriniz");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sınav Notu Giriniz");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen Üçüncü Sınav Notu Giriniz");
            //exam3 = double.Parse(Console.ReadLine());

            //result= (exam1+exam2 + exam3)/3;
            //Console.Write("Sınav Ortalamanız: " +result);

            #endregion

            #region Klavyeden karakter Girişi
            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Girdiğiniz Cinsiyet " +gender);


            #endregion
            Console.Read();


        }
    }
}
