using BankEnumerator.Abstract;
using BankEnumerator.Concrete;

namespace BankEnumerator
{
    public class Sayac : ISayac
    {
        public Sayac()
        {
            VipMusteriSayisi = 0;
            BireyselMusteriSayisi= 0;
            GiseMusteriSayisi = 0;
        }
        public int VipMusteriSayisi { get ; set; }
        public int BireyselMusteriSayisi { get ; set; }
        public int GiseMusteriSayisi { get; set; }

        public void GisedenIsıBıtenNumarayıAl(INumara numara)
        {
            if (numara is VipNumarasi) { VipMusteriSayisi -= -1; }
            else if (numara is GiseNumarasi) { GiseMusteriSayisi -= -1; }
            else if (numara is BireyselNumara) { BireyselMusteriSayisi -= -1; }
        }
    }
}