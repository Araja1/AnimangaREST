using System.ComponentModel.DataAnnotations;

namespace AngularJSAuthentication.API.Entities
{
    public class Manga
    {
        [Key]
        public int MId { get; set; }
        [MaxLength(13)]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public string Release { get; set; }
        public int Edition { get; set; }
        public byte[] Cover { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int BookNumber { get; set; }
    }
}