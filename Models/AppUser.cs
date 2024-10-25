using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tamrin_ba_ghazale.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        //public int? Mileage { get; set; }
        //public string? ProfileImageUrl { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [ForeignKey("Adress")]
        public int? AdressId {  get; set; }  
        public Adress? Adress { get; set; }

        //public string? AdressId { get; set; }
        //[ForeignKey (nameof("AdressId"))] public Adress? Adress { get; set; }

        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }


    }
}
