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

namespace Sunum.Personel
{
    public partial class PersonelAnaEkran : Form
    {
        private IPersonelService _personelService;
        public PersonelAnaEkran(IPersonelService personelService)
        {
            InitializeComponent();
            _personelService = personelService;
        }

        private void ListeyiGetir()
        {
            DGWPersonel.DataSource=_personelService.Listele();
        }

        private void PersonelAnaEkran_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        private void DGWPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelId.Text = DGWPersonel.CurrentRow.Cells[0].Value.ToString();
            txtPersonelNo.Text = DGWPersonel.CurrentRow.Cells[1].Value.ToString();
            txtPersonelAd.Text = DGWPersonel.CurrentRow.Cells[2].Value.ToString();
            txtPersonelSoyad.Text = DGWPersonel.CurrentRow.Cells[3].Value.ToString();
            txtPersonelMaas.Text = DGWPersonel.CurrentRow.Cells[4].Value.ToString();
            txtPersonelDepartman.Text = DGWPersonel.CurrentRow.Cells[5].Value.ToString();
        }
        private void AlanlariTemizle()
        {
            txtPersonelId.Text = "";
            txtPersonelNo.Text = "";
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelMaas.Text = "";
            txtPersonelDepartman.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" && txtPersonelDepartman.Text != "" && txtPersonelId.Text != "" && txtPersonelMaas.Text != "" && txtPersonelNo.Text != "" && txtPersonelSoyad.Text != "")
            {
                _personelService.Sil(new Entities.Entities.Personel
                {
                    PersonelId = Convert.ToInt32(txtPersonelId.Text)
                });
                MessageBox.Show($"{txtPersonelId.Text} Id'li Personel Silindi");
                AlanlariTemizle();
                ListeyiGetir();
            }
            else
                MessageBox.Show("Lütfen silmek istediğiniz kişiyi Seçiniz");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" && txtPersonelDepartman.Text != "" && txtPersonelId.Text != "" && txtPersonelMaas.Text != "" && txtPersonelNo.Text != "" && txtPersonelSoyad.Text != "")
            {
                _personelService.Guncelle(new Entities.Entities.Personel
                {
                    PersonelId = Convert.ToInt32(txtPersonelId.Text),
                    PersonelNo = Convert.ToInt32(txtPersonelNo.Text),
                    PersonelAd = txtPersonelAd.Text,
                    PersonelSoyad = txtPersonelSoyad.Text,
                    Maas = Convert.ToDecimal(txtPersonelMaas.Text),
                    Departman = txtPersonelDepartman.Text
                });
                MessageBox.Show($"{txtPersonelId.Text} Id'li Personel Güncellendi");
                AlanlariTemizle();
                ListeyiGetir();
            }
            else
                MessageBox.Show("Güncellemek istediğiniz değerler boş girilemez");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle(_personelService);
            personelEkle.ShowDialog();
            ListeyiGetir();
        }

        private void PersonelAnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
