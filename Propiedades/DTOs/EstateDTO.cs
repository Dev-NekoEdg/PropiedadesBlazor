using Propiedades.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propiedades.DTOs
{
    public class EstateDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The Name length should be more than 3 and no more  than 50 characters.")]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "The description allows no more than  250 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Area is required.")]
        [Range(5, 5000, ErrorMessage = "The Area should be between 5 and 5000 square meters.")]
        public int? Area { get; set; }

        [Required(ErrorMessage = "The Number of Rooms is required.")]
        [Range(1, 100, ErrorMessage = "There should be at least 1 room.")]
        public int? Rooms { get; set; }
        
        [Required(ErrorMessage = "The Number of Bathrooms is required.")]
        [Range(1, 100, ErrorMessage = "There should be at least 1 bathroom.")]
        public int? Bathrooms { get; set; }

        [Required(ErrorMessage = "The Number of Parkinglots is required.")]
        public int? Parkinglots { get; set; }

        [Required(ErrorMessage = "The Price is required.")]
        public double? Price { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }

        //[ForeignKey("CategoryId")]
        //public virtual Category Category { get; set; }
    }
}
