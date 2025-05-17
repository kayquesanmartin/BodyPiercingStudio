using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BodyPiercingStudio.API.Models
{
    public class Jewelry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public string Material { get; set; } // Ouro, Prata, Aço Cirúrgico, etc.
        public string Category { get; set; } // Argola, Barra, Stud, etc.
        public string ImageUrl { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; } = true; // Por padrão, o item está ativo
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}