using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tamrin_ba_ghazale.Data.Enum;

namespace tamrin_ba_ghazale.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } 
        public string? Image {  get; set; }

       

        [ForeignKey("Adress")]
        public int? AdressId {  get; set; }
        public Adress?Adress { get; set; }

        [ForeignKey("AppUser")]
        public string? UserId { get; set; }
        public AppUser? AppUser { get; set; }


    }
}
