using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Unicode]
        [Required]
        [MaxLength(24)]
        public string Name { get; set; }
        [Required]
        public double Password { get; set; }

        public override string ToString()
            => $"[{Id}]\tName: {Name}\tPrice: {Password}";
    }
}
