using DataAccess.Dal;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    class UrunService : IUrunService
    {
        private IUrunDal _urunDal;

        public UrunService(IUrunDal urunDal)
        {
            _urunDal= urunDal;
        }
        public void Ekle(Urun urun)
        {
            _urunDal.Ekle(urun);
        }

        public void Guncelle(Urun urun)
        {
            _urunDal.Guncelle(urun);
        }

        public List<Urun> Listele()
        {
            return _urunDal.Listele().ToList();
        }

        public void Sil(Urun urun)
        {
            _urunDal.Sil(urun);
        }
    }
}
