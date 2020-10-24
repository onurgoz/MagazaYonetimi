using DataAccess.Dal;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class PersonelService : IPersonelService
    {
        PersonelDal personel = new PersonelDal();
        private IPersonelDal _personelDal;
        public PersonelService(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public void Ekle(Personel personel)
        {
            _personelDal.Ekle(personel);
        }

        public void Guncelle(Personel personel)
        {
            _personelDal.Guncelle(personel);
        }

        public List<Personel> Listele()
        {
            return _personelDal.Listele().ToList();
        }

        public void Sil(Personel personel)
        {
            _personelDal.Sil(personel);
        }
    }
}
