using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEnumerator.Concrete
{
    internal class Banka : IBanka
    {
        public Banka()
        {
            Giseler=new List<IGise>();
            MesaiMi = false;
        }
        public List<IGise> Giseler { get ; set; }
        public IKuyruk Kuyruk { get ; set ; }
        public INumarator Numarator { get; set ; }
        public ISayac Sayac { get ; set ; }
        public bool MesaiMi { get; set ; }
        public void MesaiBaslat(int giseSayisi)
        {
            Kuyruk=new Kuyruk();
            Sayac = new Sayac();
            Numarator=new Numarator();
            for (int i = 0; i < giseSayisi; i++)
            {
                IGise gise=new Gise();
            }
        }

        public void MesaiBitir()
        {
            throw new NotImplementedException();
        }
    }
}
