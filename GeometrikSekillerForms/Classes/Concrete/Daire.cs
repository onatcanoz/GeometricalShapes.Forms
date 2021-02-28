using GeometrikSekillerForms.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekillerForms.Classes.Concrete
{
    public class Daire : SekillerBase
    {
        public override double AlanHesapla()
        {
            return Math.Pow(TemelUzunluk , 2) * 3 ;
        }

        public override double CevreHesapla()
        {
            return 2 * 3 * TemelUzunluk;
        }
    }
}
