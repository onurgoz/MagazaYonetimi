using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IUrunService
    {
        void Ekle(Urun urun);
        void Sil(Urun  urun);
        void Guncelle(Urun urun);
        List<Urun> Listele();
    }
}
