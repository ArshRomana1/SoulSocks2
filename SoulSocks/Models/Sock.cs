using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SoulSocks.Models
{
    public class Sock
    {

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Length { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Colour { get; set; }


        [Range(1, 500)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1,5)]
        public int Rating { get; set; }
    }
}