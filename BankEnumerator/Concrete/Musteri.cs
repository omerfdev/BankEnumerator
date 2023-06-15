using BankEnumerator.Abstract;
using BankEnumerator.Concrete;

namespace BankEnumerator
{
    public class Musteri : IMusteri
    {
        public string TC { get ; set ; }
        public IslemTipi IslemTipi { get ; set ; }
        public INumara Numara { get ; set ; }

        public event Banka.HaberTipi NumaratorBenGeldim;
        public event Banka.HaberTipi GiseBenGeldim;

        void SıraNumarasıAl()
        {
            if (TC != null)
            {
                NumaratorBenGeldim(this);
            }


        }
        public void NumaratörüKontrolEt(INumara numara)
        {
            if (numara==Numara)
            {
                GiseBenGeldim(this);
            }
        }
    }
}