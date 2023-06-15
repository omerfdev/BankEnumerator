using BankEnumerator.Abstract;
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
            //Banka b = new Banka();
            //b.Giseler.Add(new IGise );
            cmbBoxIslem.Items.AddRange(Enum.GetNames(typeof(IslemTipi)));

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
            musteri.NumaratorBenGeldim += banka.Numarator.NumaraÜret;
            //numaratör ben geldim eventi tetiklendiğinde numaratör içerisindeki numara üret metodu çağrılacak.
            foreach (var gise in banka.Giseler)
            {
                musteri.GiseBenGeldim+=gise.Kontrol;
            }
            musteri.SıraNumarasıAl();
        }
    }
}