using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEgitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YAZDIRMA KOMUTLARI
            //System.Console.WriteLine("deneme");
            //System.Console.Read();

            //Console.WriteLine("***** Yemek Kategorileri");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar"); 
            //Console.WriteLine("4-Salatalar"); 
            //Console.WriteLine("5-Tatlılar"); 
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri");
            #endregion
            #region STRİNG DEĞİŞKENLER 
            //string name;
            //name = "Çetin";
            //Console.WriteLine(name);
            //string customerName;
            //string customerSurname;
            //string customerEmail, customerPhone, district, city;
            //customerName = "Mehmet";
            //customerSurname = "Çınar";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = "+90 505 51 2 4 6";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName+ " "+customerSurname);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("E mail : " + customerEmail);
            //Console.WriteLine( "Adres: "+district+" /"+city);
            //Console.WriteLine("--------------------------------");

            //customerName = "Çetin";
            //customerSurname = "Yurtsever";
            //customerPhone = "+90 505 513 28 23 ";
            //customerEmail = "cetin@gmail.com";
            //district = "Menteşe";
            //city = "Muğla";
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("E mail : " + customerEmail);
            //Console.WriteLine("Adres: " + district + " /" + city);
            //Console.WriteLine("--------------------------------");

            #endregion
            #region INT DEĞİŞKENLER
            int number = 35;
            Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---- Kola: " + cokePrice + " TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("---- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("---- Su: " + waterPrice + " TL");
            Console.WriteLine();


            int hamburgerCount=3;
            int cokeCount=3;
            int waterCount=3;
            int friesCount=1;
            int pizzaCount=0;
            int lemonCount=0;

            int totalHamburgerPrice = 0;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            Console.WriteLine("Hamburger Tutarı :" + totalHamburgerPrice);


            #endregion
        }

    }
}
