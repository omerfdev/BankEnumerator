﻿using BankEnumerator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEnumerator.Concrete
{
    public class GiseNumarasi : INumara
    {
        public int SıraNumarası { get; set; }
        public DateTime IslemTarih { get; set; }
        public int OnundeKacKisiVar { get; set; }
        public override string ToString()
        {
            return $"{SıraNumarası}--{IslemTarih}";
        }
    }
}
