﻿using BankEnumerator.Abstract;
using BankEnumerator.Concrete;

namespace BankEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static IBanka banka;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBoxIslem.Items.Add(IslemTipi.Bireysel);
            cmbBoxIslem.Items.Add(IslemTipi.Gise);
            //cmbBoxIslem.Items.AddRange(Enum.GetNames(typeof(IslemTipi)));
        }

        private void btnCreateBank_Click(object sender, EventArgs e)
        {
            banka = new Banka();
            banka.MesaiBaslat(3);
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            IMusteri musteri = new Musteri();
            musteri.IslemTipi = (IslemTipi)cmbBoxIslem.SelectedItem;
            musteri.TC = txtBoxTurkishID.Text;
            musteri.NumaratorBenGeldim += banka.Numarator.NumaraUret;

            foreach (var gise in banka.Giseler)
            {
                musteri.GiseBenGeldim += gise.Kontrol;
            }
            musteri.SıraNumarasıAl();
            banka.Kuyruk.NumaraAtadim += musteri.NumaratoruKontrolEt;

            ListeleriYukle();
        }

        private void ListeleriYukle()
        {
            //foreach (ListBox item in this.Controls)
            //{
            //    if (item is ListBox)
            //    {
            //        item.DataSource = null;
            //    }
            //}

            lstBoxBireysel.DataSource = null;
            lstBoxGise.DataSource = null;
            lstBoxVip.DataSource = null;
            lstBoxVip.DataSource = banka.Kuyruk.VipNumaraListesi;
            lstBoxGise.DataSource = banka.Kuyruk.GiseNumaraListesi;
            lstBoxBireysel.DataSource = banka.Kuyruk.BireyselNumaraListesi;

        }

        private void btnCreateHelpDesk_Click(object sender, EventArgs e)
        {
            GiseOlustur(banka.Giseler);
        }

        private void GiseOlustur(List<IGise> giseler)
        {
            for (int i = 0; i < giseler.Count; i++)
            {
                Button btn = new Button();
                btn.Text = "Available";
                btn.Width = 100;
                btn.Height = 100;
                btn.Click += new EventHandler(Available);
                flwPanel.Controls.Add(btn);


            }

        }

        private void Available(object? sender, EventArgs e)
        {
            banka.Giseler[0].IslemYap();
        }
    }
}