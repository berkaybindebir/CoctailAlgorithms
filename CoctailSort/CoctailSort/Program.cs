using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoctailSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elimizde 4124, 214, 43, 10, 7, 2, 1 sayıları var
            int[] d = Coctail_Sort(new int[] {4124, 214, 43, 10, 7, 2, 1});

            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i] + " ");
            }

            Console.ReadKey();
        }

        
        static int[] Coctail_Sort(int[] dizi) {
            //Burda Döngü oluşturuyoruz
            while (true) {
                //Başlangıçta degisti değişkenimizi false yapıyoruz ki değişimini kontrol edebilelim
                bool degisti = false;
                for (int i = 0; i < dizi.Length - 1; i++)
                {
                    // Burda dizinin i'inci elemanıyla i'den sonraki elemanın büyüklük durumuna bakıyoruz
                    if (dizi[i + 1] < dizi[i])
                    {
                        //dizi > Dizi+1 ise alttaki komutlar çalışıyor
                        int temp = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = temp;
                        degisti = true;
                    }
                }
                // Eğer degisti false ise sıralama doğrudur yani döngüye girmeyecek döngüyü kırıyoruz
                if (!degisti)
                    break;

                //Burda tekrar döngüye sokuyoruz ki yer değiştirme işlemini yapalım
                //Üst satırda dizi temp değişkenine referans ettik
                for (int i = dizi.Length - 1; i > 0; i--)
                {
                    //Burda da index sayısıyle bir önceki index arasında büyüklük kontrolü yapılıp temp değişkeniyle yer değişimi yapılıyor
                    if (dizi[i] < dizi[i - 1]) {
                        int temp = dizi[i];
                        dizi[i] = dizi[i - 1];
                        dizi[i - 1] = temp;
                    }
                }
            }

            //Burda da dizi arrayı return ediliyor
            return dizi;
        }
    }
}
