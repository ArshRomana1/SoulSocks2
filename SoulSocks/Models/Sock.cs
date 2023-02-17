using System;
using System.ComponentModel.DataAnnotations;
namespace SoulSocks.Models
{
    public class Sock
    {

        public int Id { get; set; }
        public string Brand { get; set; }

        public string Material { get; set; }
        public string Length { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }
    }
}