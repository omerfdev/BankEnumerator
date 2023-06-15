using BankEnumerator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEnumerator.Concrete
{
    public class Banka : IBanka
    {
        public delegate void HaberTipi(object sender);
        public delegate void NumaraHaberTipi(INumara numara);
        //todo:1.)Delegate tanımlanır.public delegate void HaberTipi(object sender) 2.)Event tanımlanır EventHaberTipi        3.)Event i metoda Bağla=musteri.NumaratörBenGeldim+=Banka.numaratör.Numarauret;
        public Banka()
        {
            Giseler=new List<IGise>();
            IsWorking = false;
        }
        public List<IGise> Giseler { get ; set; }
        public IKuyruk Kuyruk { get ; set ; }
        public INumarator Numarator { get; set ; }
        public ISayac Sayac { get ; set ; }
        public static bool IsWorking { get; set ; }
        public static IMusteriDatabaseYöneticisi DBMusteri = new Database();
        /// <summary>
        /// Bu metod bankadaki gişelerin mesaisini başlatır.
        /// </summary>
        /// <param name="giseSayisi"></param>
        /// <exception cref="Exception"></exception>
        public void MesaiBaslat(int giseSayisi)
        {
            Kuyruk=new Kuyruk();
            Sayac = new Sayac();
            Numarator=new Numarator();
            if (giseSayisi>3) { throw new Exception("En fazla oluşturabilirsin..."); }
            for (int i = 0; i < giseSayisi; i++)
            {
                IGise gise=new Gise();
                //TODO:KUYRUKBENMÜSAİTİM, SAYAC BENİM İŞİM BİTTİ..
                Giseler.Add(gise);

            }
            IsWorking=true;
        }
        /// <summary>
        /// Mesai bitir metodu...
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void MesaiBitir()
        {
            throw new NotImplementedException();
        }
    }
}
