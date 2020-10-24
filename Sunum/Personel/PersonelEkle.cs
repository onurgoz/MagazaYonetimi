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
    public partial class PersonelEkle : Form
    {
        private IPersonelService _personelService;
        public PersonelEkle(IPersonelService personelService)
        {
            InitializeComponent();
            _personelService = personelService;
        }
       


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" && txtPersonelDepartman.Text != "" && txtPersonelMaas.Text != "" && txtPersonelNo.Text != "" && txtPersonelSoyad.Text != "")
            {
                _personelService.Ekle(new Entities.Entities.Personel
                {
                    PersonelNo = Convert.ToInt32(txtPersonelNo.Text),
                    PersonelAd = txtPersonelAd.Text,
                    PersonelSoyad = txtPersonelSoyad.Text,
                    Maas = Convert.ToDecimal(txtPersonelMaas.Text),
                    Departman = txtPersonelDepartman.Text
                });
                MessageBox.Show("Personel Eklendi");
                this.Close();
            }
            else
                MessageBox.Show("Lütfen Personel Eklemek İçin Bilgileri Eksiksiz doldurun");
        }
    }
}
