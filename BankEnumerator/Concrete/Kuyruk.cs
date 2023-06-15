using BankEnumerator.Abstract;
using BankEnumerator.Concrete;

namespace BankEnumerator
{
    public class Kuyruk : IKuyruk
    {
        public Kuyruk()
        {
            VipNumaraListesi=new List<INumara> ();
            BireyselNumaraListesi = new List<INumara> ();
            GiseNumaraListesi= new List<INumara> ();
            sayac = 0;
        }
        public List<INumara> VipNumaraListesi { get ; set ; }
        public List<INumara> BireyselNumaraListesi { get; set ; }
        public List<INumara> GiseNumaraListesi { get ; set ; }
        public int sayac { get; set; }

        public event Banka.NumaraHaberTipi NumaraAtadim;

        public void GiseyeNumaraGonder(object sender)
        {
            throw new NotImplementedException();
        }

        public void NumaratordenNumaraAl(INumara numara)
        {
            if (numara is VipNumarasi)
            {
                VipNumaraListesi.Add(numara);
            }
            else if (numara is BireyselNumara)
            {
                BireyselNumaraListesi.Add(numara);
            }
            else if (numara is GiseNumarasi)
            {
                GiseNumaraListesi.Add(numara);
            }
        }
    }
}