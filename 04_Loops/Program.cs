﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}
            //Console.Write("lütfen ekrana yazılması istediğiniz adedi giriniz");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion
            #region For döngüsü ile karar yapıları
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);


            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue);
            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++) {
            //    bacterium *= 2;
            //    Console.WriteLine(i+" . saatin sonunda baktesi sayısı : "+bacterium);
            //}
            #endregion
            #region While Döngüsü
            //int i = 1;
            //while (i <= 10) {
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}
            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Örnek Sınav sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamı hesaplayan kodu yazınız
            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = number % 10;
            //hundreds = number / 100;
            //tens=(number % 100)/10;

            //sum = hundreds + tens + ones;
            //Console.WriteLine(number+" Sayısının rakamları toplamı: "+ sum);
            #endregion
            Console.ReadLine();
        }
    }
}
