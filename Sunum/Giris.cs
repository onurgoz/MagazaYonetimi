using Business;
using Business.Dependenciesenjection;
using Sunum.Personel;
using Sunum.Urun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            _personelService = KernelFactory.GetService<IPersonelService>();
            _urunService = KernelFactory.GetService<IUrunService>();
        }
        private IPersonelService _personelService;
        private IUrunService _urunService;

        private void PBPersonel_Click(object sender, EventArgs e)
        {
            PersonelAnaEkran personelAnaEkran = new PersonelAnaEkran(_personelService);
            personelAnaEkran.ShowDialog();
            
        }

        private void PBUrun_Click(object sender, EventArgs e)
        {
            UrunAnaEkran urunAnaEkran = new UrunAnaEkran(_urunService);
            urunAnaEkran.ShowDialog();
            
        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
