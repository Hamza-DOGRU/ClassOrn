using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args) 
        {   //class değşkeni oluşturmak
            product urun1 = new product();
            urun1.urunadi = "Telefon";
            urun1.marka = "İPhone";
            urun1.model = "XS Max";
            urun1.fiyat = 9000;
            //class değşkeni oluşturmak
            product urun2 = new product();
            urun2.urunadi = "Telefon";
            urun2.marka = "Samsung";
            urun2.model = "Note 10";
            urun2.fiyat = 9000;
            product[] urunler = new product[] { urun1, urun2 };
            //Foreach döngüsü kullanarak listeleme
            foreach (var yz in urunler)
            {
                Console.WriteLine(yz.urunadi + ":" + yz.marka + ":" + yz.model);
            }
            //For döngüsü kullanarak listeleme
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunadi + ":" + urunler[i].marka+":"+urunler[i].model);
            }
            //While döngüsü kullanarak listeleme
            int syc = 0;   //Döngü için bir sayac değişkeni tanımladım
            while (syc<urunler.Length)    //tanımladığım değişkeni ürünler listesinin uzunluğuna göre şartladım
            {
                Console.WriteLine(urunler[syc].urunadi + ":" + urunler[syc].marka + ":" + urunler[syc].model); //ürünler listesinin sayaçıncı elemanının bilgilerini çektim
                syc++; 
                
            }
            Console.ReadKey();


        }
    }//Class oluşturmak
    class product
    {
        public string urunadi { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public int fiyat { get; set; }

    }
}

