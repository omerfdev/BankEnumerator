using System.Globalization;

namespace BankEnumerator.Abstract
{
    public interface INumara
    {
        public int SıraNumarası { get; set; }
        public DateTime IslemTarih { get; set; }
        public int OnundeKacKisiVar { get; set; }
    }
}