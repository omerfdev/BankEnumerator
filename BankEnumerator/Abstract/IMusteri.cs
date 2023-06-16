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
       
        event HaberTipi NumaratorBenGeldim;
       event HaberTipi GiseBenGeldim;
        public  string TC { get; set; }
        IslemTipi IslemTipi { get; set; }
        INumara Numara { get; set; }
        public void SıraNumarasıAl();
        

       
        public void NumaratörüKontrolEt(INumara numara);
    }
}
