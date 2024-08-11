using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik_Encapsulation
{
    public class Araba   // Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.
    {

        // Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı

        private string _brand { get; set; }
        private string _model { get; set; }
        private string _color { get; set; }
        private int _doorCount;

        public Araba(string Brand, string Model, string Color, int DoorCount)
        {
            _brand = Brand;
            _model = Model;
            _color = Color;
            _doorCount = DoorCount;

        }


        public int DoorCount
        {
            get
            {
                return _doorCount;
            }


            set
            {
                if (value == 2 && value==4)    // Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak 
                {
                    _doorCount = value;
                       // konsol ekranında bir uyarı mesajı yayınlayalım
                }

                else
                {
                    _doorCount = -1;
                    Console.WriteLine("-1 e ayarlandı.");           // ve Kapı Sayısı değerini -1 olarak atayalım.
                }

            }

        }

   

        public void DisplayStatus()
        {
            Console.WriteLine("Markası"+_brand);
            Console.WriteLine("Modeli"+_model);
            Console.WriteLine("Kapı sayısı"+_doorCount);
        }



    }
}