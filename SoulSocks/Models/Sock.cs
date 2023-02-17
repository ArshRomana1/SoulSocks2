using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SoulSocks.Models
{
    public class Sock
    {

        public int Id { get; set; }
        public string Brand { get; set; }

        public string Material { get; set; }
        public string Length { get; set; }
        public string Colour { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int Rating { get; set; }
    }
}