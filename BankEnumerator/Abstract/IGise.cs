using BankEnumerator.Abstract;
using static BankEnumerator.Concrete.Banka;

namespace BankEnumerator
{
    public interface IGise
    {
        //KuyrukBenMusaitim,SayacİsimBitti
        event HaberTipi KuyrukBenMusaitim;
        event NumaraHaberTipi SayacIsımBıttı;
        INumara islemYapilanNumara { get; set; }
        void İslenYap();
        void Kontrol(object sender);

    }
}