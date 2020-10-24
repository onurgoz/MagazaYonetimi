
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IPersonelService
    {
        void Ekle(Personel personel);
        void Sil(Personel personel);
        void Guncelle(Personel personel);
        List<Personel> Listele();
    }
}
