using BankEnumerator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEnumerator.Concrete
{
    public delegate void HaberTipi(object sender);
    public delegate void NumaraHaberTipi(INumara numara);

    public class Banka : IBanka
    {
       
        public Banka()
        {
            Giseler = new List<IGise>();
            IsWorking = false;
        }
        public List<IGise> Giseler { get; set; }
        public IKuyruk Kuyruk { get; set; }
        public INumarator Numarator { get; set; }
        public ISayac Sayac { get; set; }
        public static bool IsWorking { get; set; }
        public static IMusteriDatabaseYoneticisi DBMusteri = new Database();
        /// <summary>
        /// Bu metod bankadaki gişelerin mesaisini başlatır.
        /// </summary>
        /// <param name="giseSayisi"></param>
        /// <exception cref="Exception"></exception>
        public void MesaiBaslat(int giseSayisi)
        {
            Kuyruk = new Kuyruk();
            Sayac = new Sayac();
            Numarator = new Numarator();
            if (giseSayisi > 3) { throw new Exception("En fazla oluşturabilirsin..."); }
            else
            {
                for (int i = 0; i < giseSayisi; i++)
                {
                    IGise gise = new Gise();
                    gise.KuyrukBenMusaitim += Kuyruk.GiseyeNumaraGonder;
                    gise.SayacIsımBıttı += Sayac.GisedenIsıBıtenNumarayıAl;
                    Giseler.Add(gise);

                }
            }
            
            Numarator.NumaraUrettim += Kuyruk.NumaratordenNumaraAl;
            IsWorking = true;
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
