using GeometrikSekillerForms.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekillerForms.Classes.Concrete
{
    public class Kare : SekillerBase
    {
        public override double AlanHesapla()
        {
            return Math.Pow(TemelUzunluk, 2);
        }

        public override double CevreHesapla()
        {
            return TemelUzunluk * 4;
        }
    }
}
