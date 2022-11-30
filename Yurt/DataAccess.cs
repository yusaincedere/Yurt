using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Data;
using Dapper;

namespace Yurt
{
  
    class DataAccess
    {

      
        public static List<Yonetici> yoneticiYukle()
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl())){

                var output = cnn.Query<Yonetici>("select * from Yonetici", new DynamicParameters());
                return output.ToList();
            }
        }


        public static List<Ogrenci> ogrenciYukle()
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                var output = cnn.Query<Ogrenci>("select * from Ogrenci", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Ogrenci> ogrenciAra(string value)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                const string sql = "SELECT * from Ogrenci WHERE ad LIKE @value or soyad LIKE @value or tcno LIKE @value or bolum LIKE @value;";
                var output = cnn.Query<Ogrenci>(sql, new { value = "%" + value + "%"});
                return output.ToList();
            }
        }
        public static List<Ogrenci> ogrenciAraTcNo(string tcno)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                const string sql = "SELECT * from Ogrenci WHERE tcno=@tcno;";
                var output = cnn.Query<Ogrenci>(sql, new { tcno  });
                return output.ToList();
            }
        }

        public static List<Yonetici> YoneticiAraTcNo(string tcno)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                const string sql = "SELECT * from Yonetici WHERE tcno=@tcno;";
                var output = cnn.Query<Yonetici>(sql, new { tcno });
                return output.ToList();
            }
        }

        public static void yoneticiKaydet(Yonetici yonetici)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                cnn.Execute("insert into Yonetici (tcno,ad,soyad,telno,email,sifre,dogumtarihi,profilfoto) values (@tcno,@ad,@soyad,@telno,@email,@sifre,@dogumtarihi,@profilfoto)", yonetici);
            }
        }
        public static List<Yonetici> YoneticiAra(string tcno, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                const string sql = "SELECT * from Yonetici WHERE tcno=@tcno and sifre=@password;";
                var output = cnn.Query<Yonetici>(sql, new { tcno ,  password });
                
                return output.ToList();
            }
        }
        public static List<Yonetici> YoneticiAra(string value)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                const string sql = "SELECT * from Yonetici WHERE ad LIKE @value or soyad LIKE @value or tcno LIKE @value;";
                var output = cnn.Query<Yonetici>(sql, new { value = "%" + value + "%" });
                return output.ToList();
            }
        }

        public static void ogrenciKaydet(Ogrenci ogrenci)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                cnn.Execute("insert into Ogrenci (tcno,ad,soyad,telno,email,bolum,dogumtarihi,profilfoto) values (@tcno,@ad,@soyad,@telno,@email,@bolum,@dogumtarihi,@profilfoto)", ogrenci);
            }
        }
        public static void ogrenciGuncelle(Ogrenci ogrenci)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                cnn.Execute("UPDATE Ogrenci set ad=@ad,soyad=@soyad,telno=@telno,email=@email,bolum=@bolum,dogumtarihi=@dogumtarihi,profilfoto=@profilfoto where tcno=@tcno",ogrenci);
            }
        }
        public static void ogrenciSil(Ogrenci ogrenci)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                cnn.Execute("DELETE FROM Ogrenci WHERE tcno=@tcno",ogrenci);
            }
        }
        public static void yoneticiSil(Yonetici yonetici)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
            {
                cnn.Execute("DELETE FROM Yonetici WHERE tcno=@tcno",yonetici);

            }
        }


        public static void yoneticiGuncelle(Yonetici yonetici)
        {
            using (IDbConnection cnn = new SQLiteConnection(connectionStringAl()))
           {
                cnn.Execute("UPDATE Yonetici set ad=@ad,soyad=@soyad,telno=@telno,email=@email,sifre=@sifre,dogumtarihi=@dogumtarihi,profilfoto=@profilfoto where tcno=@tcno", yonetici);
            }
        }
        private static string connectionStringAl(string name="Default")
        {
            string returnValue = null;
            ConnectionStringSettings settings =
        ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;


            Console.WriteLine(returnValue);
            return returnValue;

        }
        

    }
}
