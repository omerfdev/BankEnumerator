using BankEnumerator.Abstract;
using BankEnumerator.Concrete;

namespace BankEnumerator
{
    public class Gise : IGise
    {
        public INumara islemYapilanNumara { get; set; }

        public event HaberTipi KuyrukBenMusaitim;
        public event NumaraHaberTipi SayacIsımBıttı;

        public void Kontrol(object sender)
        {
            IMusteri musteri = sender as IMusteri;
            if (musteri.Numara == islemYapilanNumara)
            {

                IslemYap();


            }
        }

        public void IslemYap()
        {

            SayacIsımBıttı(islemYapilanNumara);
            KuyrukBenMusaitim(this);
        }
    }
}