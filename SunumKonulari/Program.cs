using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunumKonulari
{
    class Program
    {

        static Random r = new Random();

        static void Main(string[] args)
        {
            ogrenciYerlestir();
        }

        static string İsimOlusturucu()
        {
            string isimSoyisim;
            string[] ad = { "Yunus", "Emre", "Tuğçe", "Meltem", "Mehmet", "Ali", "Mine", "Merve",
            "Mahmut", "Osman", "Gamze", "Ceylin", "Gizem", "Adriana", "Cem" };
            string[] soyad = { " Diril", " Baş", " Öz", " Kaya", " Dülge",
            " Karhan", " Demir", " Özdemir", " Şentürk", " Yılmaz", " Ulusoy", " Saat", " Bolugur", " Lima", " Uğur" };      

            OgrenciBilgi ogrenci_bilgi = new OgrenciBilgi();                  

                ogrenci_bilgi.isimAta(ad[r.Next(15)]);
                ogrenci_bilgi.soyadAta(soyad[r.Next(15)]);

            isimSoyisim=string.Concat(ogrenci_bilgi.isimVer(),ogrenci_bilgi.soyadVer());

            return isimSoyisim;
          
        }
        static int kisiSayisiKontrol(int n)
        {   

            while(n<1 && n>36)
            {
                Console.WriteLine("Hatalı giriş tekrar giriniz:");
                n = Convert.ToInt32(Console.ReadLine());
            }

            return n;
        }
        static int kisiSayisi()
        {

            int kisiSay;            /*yalnızca integer alınması gerekiyor*/
            Console.WriteLine("Öğrenc sayısını giriniz!");
            kisiSay = Convert.ToInt32(Console.ReadLine());
            kisiSayisiKontrol(kisiSay);

            return kisiSay;
        }     
        static void ogrenciYerlestir()
        {
            string[,] konuOgrenci = new string[4, 10];
            

            int n;

            n=kisiSayisi();

            for(int k=0;k< n; k++)
            {
                if (k < 10)
                {   
                    for(int i=0;i<k+1;i++)
                    konuOgrenci[0, i] = İsimOlusturucu();
                  
                }
                else if (k > 9 && k <= 19)
                {
                    for (int i = 0; i < k-9; i++)
                        konuOgrenci[1, i] = İsimOlusturucu();
                    
                }
                else if (k > 19 && k < 30)
                {
                    for (int i = 0; i < k-19; i++)
                        konuOgrenci[2, i] = İsimOlusturucu();
                
                }
                else
                {
                    for (int i = 0; i < k-29; i++)
                        konuOgrenci[3, i] = İsimOlusturucu();
                    
                }

            }

            tabloBas(konuOgrenci);

            Console.ReadKey();

        }          
        static void tabloBas(string[,] matris)
        {
            string[] konular = {"Genetik Algoritmalar", "Bulanık Mantık", "Makine Öğrenmesi", "Öngörüye Dayalı Analitik",
                                "Zeki Sistemler","Uzman Sistemler","Doğal Dil İşleme","Robotbilimde Yapay Zeka","Veri Madenciliği",
                                "Karınca Kolonisi Algoritmaları "};


            for (int m = 0; m < matris.GetLength(1); m++)
                {
                Console.WriteLine("---------------");
                Console.WriteLine(konular[m]);
                Console.WriteLine("---------------");
                for (int k = 0; k < matris.GetLength(0); k++)
                    {
                        
                        Console.WriteLine(matris[k, m]);
                        if (matris[k, m] == null)
                            break;           
                    }
                }

            ogrenciYerlestir();
        }

    }
}
