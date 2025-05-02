using KisiselBilgiDogrulama.Attributes;

namespace KisiselBilgiDogrulama.Models
{
    public class Ogrenci
    {
        [ZorunluAlan("Ad alanı boş bırakılamaz.")]
        public string Ad { get; set; }

        [ZorunluAlan("Soyad alanı boş bırakılamaz.")]
        public string Soyad { get; set; }

        [ZorunluAlan("Bölüm alanı boş bırakılamaz.")]
        public string Bolum { get; set; }
    }
}
