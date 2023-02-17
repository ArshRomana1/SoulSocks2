using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SoulSocks.Models
{
    public class SockMaterialViewModel
    {
        public List<Sock> Socks { get; set; }
        public SelectList Material { get; set; }
        public string SockMaterial { get; set; }
        public string SearchString { get; set; }
    }
}