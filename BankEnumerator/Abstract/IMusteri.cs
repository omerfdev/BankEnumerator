using BankEnumerator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankEnumerator.Concrete.Banka;

namespace BankEnumerator.Abstract
{
    public interface IMusteri
    {
        //NumaratörBenGeldim
        //GiseBenGeldim
        event HaberTipi NumaratorBenGeldim;//Numaratör ben geldim eventini haber tipi isimli delege temsil ediyor.
        event HaberTipi GiseBenGeldim;//Bağlama yapılmadı.Nesne oluşunca bağlıyacağım.
        public  string TC { get; set; }
        IslemTipi IslemTipi { get; set; }
        INumara Numara { get; set; }

    }
}
