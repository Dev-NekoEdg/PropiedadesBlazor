using System.ComponentModel.DataAnnotations;

namespace Propiedades.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Requiered.")]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
