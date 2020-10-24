using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum.Urun
{
    public partial class UrunEkle : Form
    {
        private IUrunService _urunService;
        public UrunEkle(IUrunService urunService)
        {
            InitializeComponent();
            _urunService = urunService;
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            if (txtUrunId.Text != "" && txtUrunAd.Text != "" && txtKategoriAd.Text != "" && txtFiyat.Text != "")
            {
                _urunService.Ekle(new Entities.Entities.Urun
                {
                    UrunAd = txtUrunAd.Text,
                    Fiyat = Convert.ToDecimal(txtFiyat.Text),
                    KategoriAd = txtKategoriAd.Text
                });
                MessageBox.Show("Ürün Eklendi");
                this.Close();
            }
            else
                MessageBox.Show("Lütfen Ürün Eklemek İçin Bilgileri Eksiksiz Doldurun");
        }
    }
}
