using DataAccess.Baglanti;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Dal.BaseDal
{
    public class BaseDal<TEntity> : IBaseDal<TEntity>
        where TEntity : class, IEntity, new()
    {
        public void Ekle(TEntity entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var eklenenEntity = baglanti.Entry(entity);
                eklenenEntity.State = EntityState.Added;
                baglanti.SaveChanges();
            }
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filter)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                return baglanti.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Guncelle(TEntity entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var guncellemeEntity = baglanti.Entry(entity);
                guncellemeEntity.State = EntityState.Modified;
                baglanti.SaveChanges();
            }
        }

        public List<TEntity> Listele()
        {
            using (var baglanti=new MagazaYonetimDB())
            {
                return baglanti.Set<TEntity>().ToList();
            }
        }

        public void Sil(TEntity entity)
        {
            using (var baglanti = new MagazaYonetimDB())
            {
                var silinenEntity = baglanti.Entry(entity);
                silinenEntity.State = EntityState.Deleted;
                baglanti.SaveChanges();
            }
        }

        void IBaseDal<TEntity>.Getir(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
