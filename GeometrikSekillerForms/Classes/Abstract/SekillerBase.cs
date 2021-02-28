using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekillerForms.Classes.Abstract
{
    public abstract class SekillerBase
    {
        /// <summary>
        /// Şekildeki taban uzunluğu veya yarıçap
        /// </summary>
        public double TemelUzunluk { get; set; }

        public abstract double AlanHesapla();
        public abstract double CevreHesapla();
    }
}
