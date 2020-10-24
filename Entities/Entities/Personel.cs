using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Personel:IEntity
    {
        [Key]
        public int PersonelId { get; set; }
        public int PersonelNo { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public decimal Maas { get; set; }
        public string Departman { get; set; }
    }
}
