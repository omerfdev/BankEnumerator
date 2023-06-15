using BankEnumerator.Abstract;
using BankEnumerator.Concrete;

namespace BankEnumerator
{
    public class Gise : IGise
    {
        public INumara islemYapilanNumara { get ; set ; }

        public event Banka.HaberTipi KuyrukBenMusaitim;
        public event Banka.NumaraHaberTipi SayacIsımBıttı;

        public void Kontrol(object sender)
        {
           IMusteri musteri = sender as IMusteri;
            if (musteri.Numara == islemYapilanNumara) 
            {

                İslenYap();


            }
        }

        public void İslenYap()
        {
            //İşlemleri yaptı.
            SayacIsımBıttı(islemYapilanNumara);
            KuyrukBenMusaitim(this);
        }
    }
}