using BankEnumerator.Abstract;
using BankEnumerator.Concrete;
using System.Diagnostics.Eventing.Reader;

namespace BankEnumerator
{
    public class Numarator : INumarator
    {
        public Numarator()
        {
            BireyselSiraSayaci = 1000;
            GiseSiraSayaci = 2000;
            VipSiraSayacı = 3000;
        }
        public int VipSiraSayacı { get; set; }
        public int BireyselSiraSayaci { get; set; }
        public int GiseSiraSayaci { get; set; }

        public event Banka.NumaraHaberTipi NumaraUrettim;

        public void NumaraÜret(object sender)
        {
            if (Banka.IsWorking == true)
            {
                IMusteri musteri = sender as IMusteri;
                bool Vipmi = Banka.DBMusteri.VipMi(musteri.TC);
                INumara numara = null;
                if (Vipmi)
                {
                    numara = new VipNumarasi();
                    numara.SıraNumarası = VipSiraSayacı;
                    numara.IslemTarih = DateTime.Now;
                    numara.OnundeKacKisiVar = numara.SıraNumarası - 3000;//Düzeltilecek
                    VipSiraSayacı++;
                }
                else if (musteri.IslemTipi == IslemTipi.Bireysel)
                {
                    numara = new BireyselNumara();
                    numara.SıraNumarası = BireyselSiraSayaci;
                    numara.IslemTarih = DateTime.Now;
                    numara.OnundeKacKisiVar = numara.SıraNumarası - 1000;//Düzeltilecek
                    BireyselSiraSayaci++;

                }
                else if (musteri.IslemTipi == IslemTipi.Gise)
                {
                    numara = new GiseNumarasi();
                    numara.SıraNumarası = GiseSiraSayaci;
                    numara.IslemTarih = DateTime.Now;
                    numara.OnundeKacKisiVar = numara.SıraNumarası - 2000;//Düzeltilecek
                    GiseSiraSayaci++;

                }
                else
                {
                    //HATA
                }

                musteri.Numara = numara;
                NumaraUrettim(numara);
               


                    
            }
        }
    }
}