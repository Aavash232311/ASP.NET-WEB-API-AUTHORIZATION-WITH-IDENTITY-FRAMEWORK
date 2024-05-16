using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ReactApp2.Server.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(25)]
        public string Color { get; set; } = string.Empty;
        [MaxLength(25)]
        public string Brand { get; set; } = string.Empty;
        [MaxLength(25)]
        public string Gender { get; set; } = string.Empty;  
        public decimal Price { get; set;} = decimal.Zero;
        public string Images { get; set;} = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AvalibleSize { get; set; } = string.Empty;
        public Category? Category { get; set; }  
        public DateTime Added { get; set; } = DateTime.Now;
        public IdentityUser User { get; set; }
        public int Review { get; set; } = 0;
    }
}
