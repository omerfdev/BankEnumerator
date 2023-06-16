using BankEnumerator.Abstract;
using BankEnumerator.Concrete;


namespace BankEnumerator
{
    public interface IGise
    {
       
        event HaberTipi KuyrukBenMusaitim;
        event NumaraHaberTipi SayacIsımBıttı;
        INumara islemYapilanNumara { get; set; }
        void IslemYap();
        void Kontrol(object sender);

    }
}