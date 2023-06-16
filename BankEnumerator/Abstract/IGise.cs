using BankEnumerator.Abstract;
using BankEnumerator.Concrete;


namespace BankEnumerator
{
    public interface IGise
    {
       
        event HaberTipi KuyrukBenMusaitim;
        event NumaraHaberTipi SayacIsımBıttı;
        INumara islemYapilanNumara { get; set; }
        void İslemYap();
        void Kontrol(object sender);

    }
}