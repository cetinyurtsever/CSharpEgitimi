using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "Varşova" };

            //foreach (string city in cities)
            //{

            //    Console.WriteLine(city);

            //}

            //int[] numbers = { 1, 2, 45, 78, 96, 4545, 23, 478, 98 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //int[] numbers = { 1, 2, 45, 78, 96, 4545, 23, 478, 98 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            // Console.Read();
            #endregion
            #region Örnek sınav sistemi uygulaması
            //Console.WriteLine("***** C# Eğitim Kampı uygulaması*****");
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her Öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;  // Notları topluyoruz
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;

            //}
            
            //// Sınav Ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması {studentExamAvg[i]}");
            //    //Öğrencilerin  Geçip kalma durumları
            //    if (studentExamAvg[i] > 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("-----------------------------");
            //}

            #endregion
        //    Console.ReadLine();
        }
    }
}
