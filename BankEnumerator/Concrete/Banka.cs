﻿using BankEnumerator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEnumerator.Concrete
{
    internal class Banka : IBanka
    {
        public delegate void HaberTipi(object sender);

        //todo:1.)Delegate tanımlanır.public delegate void HaberTipi(object sender)
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
        public static IMusteriDatabaseYöneticisi DBMusteri = new Database();
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
            MesaiMi=true;
        }

        public void MesaiBitir()
        {
            throw new NotImplementedException();
        }
    }
}
