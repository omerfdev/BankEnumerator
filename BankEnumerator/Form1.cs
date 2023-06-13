using BankEnumerator.Concrete;

namespace BankEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Banka b = new Banka();
            b.Giseler.Add(new IGise );
        }
    }
}