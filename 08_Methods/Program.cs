using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar
            //() sol tarafında mor renkli bir küp bulunur
            // Geriye değer döndürmeyen metotlar
            // Void  
            //void customerList()
            //{
            //    Console.WriteLine("Ali yıldız");
            //    Console.WriteLine("Ayşe yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar Öztürk");
            //}
            //customerList();


            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();
            #endregion
            #region Geriye değer döndürmeyen parametreli metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Ali");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surName);
            //}
            //CustomerCard("Çetin", "Yurtsever");
            #endregion
            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void sum (int number1, int number2, int number3) {
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 5, 6);
            #endregion
            #region Geriye Değer Döndüren Metotlar
            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();
            //string studentCard() {
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name+" " + surname;
            //}
            //Console.WriteLine(studentCard());
            #endregion
            #region Geriye değer döndüren parametreli metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + "- Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Ülke Başkentini giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine("Türkiye", "Ankara", "Kırmızı-Beyaz");
            #endregion

            #region Geriye değer döndüren Int parametreli metotlar
            String ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {

                    return student+ " isimli ogrenci sınavı geçti. Ortalama: "+result ;
                }
                else
                {
                    return student + " isimli ogrenci başarısız. Ortalama: " + result;
                }

            }
            Console.WriteLine(ExamResult("Ali", 104, 54, 66));
            Console.WriteLine(ExamResult("veli", 45, 30, 66));
            #endregion
            Console.Read();
        }
    }
}
