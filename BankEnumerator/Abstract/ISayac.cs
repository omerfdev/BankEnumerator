using BankEnumerator.Abstract;

namespace BankEnumerator
{
    public interface ISayac
    {
        int VipMusteriSayisi { get;set; }
        int BireyselMusteriSayisi { get;set; }
        int GiseMusteriSayisi { get; set; }
        void GisedenIsıBıtenNumarayıAl(INumara numara);


    }
}