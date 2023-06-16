using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEnumerator
{
    internal interface IBanka
    {
       
        List<IGise> Giseler { get; set; }
        IKuyruk Kuyruk { get; set; }
        INumarator Numarator { get; set; }
        ISayac Sayac { get; set; }
        void MesaiBaslat(int giseSayisi);
        void MesaiBitir();

    }
}
