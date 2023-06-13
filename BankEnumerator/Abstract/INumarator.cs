﻿using static BankEnumerator.Concrete.Banka;

namespace BankEnumerator
{
    public interface INumarator
    {
        event NumaraHaberTipi NumaraUrettim;
        void NumaraÜret(object sender);
        int VipSiraSayacı {  get; set; }
        int GiseSiraSayaci { get; set; }
        int BireyselSiraSayaci { get; set; }
    }
}