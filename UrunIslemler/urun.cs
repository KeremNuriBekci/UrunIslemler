using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunIslemler
{
    class urun
    {
        //Değişkenler
        public string urunno, uruncesiti, kategori;
        public int stokmiktari, fiyat, para;

        public int bakiye()
        {
            //Bakiye ve Stok miktarı
            para = para + fiyat;
            stokmiktari = stokmiktari - 1;
            return para;
            

        }
    }
}
