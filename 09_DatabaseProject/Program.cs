using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            string tableNumber;

            Console.WriteLine("****** C# Veri Tabanı Ürün - Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış yap");

            Console.WriteLine("Lütfen Getirmek istediğiniz tablo numarasını giriniz");
            Console.Write("------------------------------------------------>");
            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JVGVDSI\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=true");


            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            connection.Close();
            foreach (DataRow Row in dataTable.Rows)
            {
                foreach (var item in Row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();

            }



            Console.Read();
        }
    }
}
