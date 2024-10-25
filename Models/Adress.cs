using System.ComponentModel.DataAnnotations;

namespace tamrin_ba_ghazale.Models
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }
}
