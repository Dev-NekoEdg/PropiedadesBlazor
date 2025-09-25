using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propiedades.Data.Models
{
    public class Estate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        [Required]
        public int Area { get; set; }

        [Required]
        public int Rooms { get; set; }
        
        [Required]
        public int Bathrooms { get; set; }

        [Required]
        public int Parkinglots { get; set; }

        [Required]
        public double Price { get; set; }
        
        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }
}
