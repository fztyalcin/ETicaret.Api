﻿using ETicaret.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Model
{
    [Table ("tblRol")]
    public class Rol
    {
        public Rol() 
        {
            Kullanicilar = new HashSet<Kullanici>();
        }
        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<Kullanici> Kullanicilar { get; set; }
    }
}
