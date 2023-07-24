using ETicaret.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaret.Api
{

    [Table("tblKullanici")]
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int RolId { get; set; }
        public DateTime KayitTarih { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public bool? EmailOnay { get; set; }
        public DateTime EmailOnayTarih { get; set; }
        public bool Aktif { get; set; }

        public virtual Rol Rol { get; set; }


    }
}
