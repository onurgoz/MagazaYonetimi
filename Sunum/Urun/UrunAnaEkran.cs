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
    public partial class UrunAnaEkran : Form
    {
        private IUrunService _urunService;
        public UrunAnaEkran(IUrunService urunService)
        {
            InitializeComponent();
            _urunService = urunService;
        }
        private void DGWUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = DGWUrun.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = DGWUrun.CurrentRow.Cells[1].Value.ToString();
            txtKategoriAd.Text = DGWUrun.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = DGWUrun.CurrentRow.Cells[3].Value.ToString();
        }
        private void ListeyiGetir()
        {
            DGWUrun.DataSource = _urunService.Listele();
        }
        private void UrunAnaEkran_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }
        private void AlanlariTemizle()
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtKategoriAd.Text = "";
            txtFiyat.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunId.Text != "" && txtUrunAd.Text != "" && txtKategoriAd.Text != "" && txtFiyat.Text != "")
            {
                _urunService.Guncelle(new Entities.Entities.Urun
                {
                    UrunId = Convert.ToInt32(txtUrunId.Text),
                    UrunAd = txtUrunAd.Text,
                    Fiyat = Convert.ToDecimal(txtFiyat.Text),
                    KategoriAd = txtKategoriAd.Text
                });
                MessageBox.Show("Urun Güncellendi");
                AlanlariTemizle();
                ListeyiGetir();
            }
            else
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Urunun Bilgilerini Tam Girin");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtUrunId.Text != "" && txtUrunAd.Text != "" && txtKategoriAd.Text != "" && txtFiyat.Text != "")
            {
                _urunService.Sil(new Entities.Entities.Urun
                {
                    UrunId = Convert.ToInt32(txtUrunId.Text)
                });
                MessageBox.Show("Urun Silindi");
                AlanlariTemizle();
                ListeyiGetir();
            }
            else
                MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü Seçin");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle=new UrunEkle(_urunService);
            urunEkle.ShowDialog();
            ListeyiGetir();
        }
    }
}
