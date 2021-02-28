using GeometrikSekillerForms.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekillerForms.Classes.Concrete
{
    public class DikUcgen : SekillerBase
    {

        public double Yukseklik { get; set; }

        public double Hipotenus => Math.Sqrt(Math.Pow(TemelUzunluk, 2) + Math.Pow(Yukseklik, 2));
        public override double AlanHesapla()
        {
            return TemelUzunluk * Yukseklik / 2;
        }

        public override double CevreHesapla()
        {
            return TemelUzunluk + Yukseklik + Hipotenus;
        }
    }
}
