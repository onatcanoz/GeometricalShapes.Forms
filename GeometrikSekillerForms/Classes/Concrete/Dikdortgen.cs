using GeometrikSekillerForms.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekillerForms.Classes.Concrete
{
    public class Dikdortgen : SekillerBase
    {
        public double Yukseklik { get; set; }
        public override double AlanHesapla()
        {
            return TemelUzunluk * Yukseklik;
        }

        public override double CevreHesapla()
        {
            return 2 * (TemelUzunluk + Yukseklik);
        }
    }
}
