using BankEnumerator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEnumerator.Concrete
{
    public class Database : IMusteriDatabaseYoneticisi
    {
        public Database()
        {
            MusteriTCleri = new List<string>() { "1111", "2222","3333","4444","5555"};
        }
        public List<string> MusteriTCleri { get; set; }
        public bool VipMi(string TC)
        {
            return MusteriTCleri.Contains(TC);
        }
    }
}
