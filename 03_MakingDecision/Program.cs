﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If
            //Console.Write("Lütfen Şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi giriniz");
            //country = Console.ReadLine();


            //if (capital=="Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}
            //int number;
            //Console.Write("Sayıyı Giriniz");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //double exam1, exam2, exam3, average;
            //string result="Hata!";
            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması:" + average);
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.Write(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi yapınız: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "Bursa" | city == "Trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut değil");
            //}
            //Console.Write("Lütfen kullancı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");

            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");

            //    Console.Read();
            //}
            #endregion
            #region Mod işlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine("Sonuç:" + result);
            //Console.Write("Lütfen 1. sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen Sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            //char team;
            //Console.Write("Lütfen Takım sembolünü giriniz");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion
            #region Örnek proje uygulaması
            //Console.WriteLine("*****C# Eğitim Kampı restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------");

            //string menuItem;
            //Console.Write("Detayını Görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine("-------Ana Yemekler-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somun");
            //    Console.WriteLine("4-Patlıcan Musakka");
            //    Console.WriteLine("-------Ana Yemekler-------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine("-------Çorbalar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("-------Çorbalar-------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine("-------Pizzalar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-------Pizzalar-------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine("-------İçecekler-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-------İçecekler-------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine("-------Tatlılar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-------Tatlılar-------");
            //    Console.WriteLine();
            //}
            #endregion
            #region Switch Case
            //Console.Write("Lütfen Ay girişi yapınız");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat");break;
            //    case 3: Console.Write("Mart");break;
            //    case 4: Console.Write("Nisan");break;
            //    case 5: Console.Write("Mayıs");break;
            //    case 6: Console.Write("Haziran");break;
            //    case 7: Console.Write("Temmuz");break;
            //    case 8: Console.Write("Ağustos");break;
            //    case 9: Console.Write("Eylül");break;
            //    case 10: Console.Write("Ekim");break;
            //    case 11: Console.Write("Kasım");break;
            //    case 12: Console.Write("Aralık");break;
            //    default: Console.Write("Hatalı veri girişi"); break;
            //}

            #endregion
            #region  Switch Case Hesap Makinası
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam:" + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark:" + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım:" + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm:" + result);
            //        break;
            //}
            #endregion
            Console.Read();
        }
    }
}