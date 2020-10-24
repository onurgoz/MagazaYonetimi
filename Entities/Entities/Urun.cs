using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Urun:IEntity
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd{ get; set; }
        public string KategoriAd { get; set; }
        public decimal Fiyat { get; set; }
    }
}
