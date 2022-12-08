using System.ComponentModel.DataAnnotations;

namespace JQueryValidationExample.Models
{
    public class Game
    {
        [Required(ErrorMessage = "Game code is required.")]
        [MinLength(4, ErrorMessage = "Game code must be at least 4 characters.")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Game name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Game description is required.")]
        public string Description { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Game price is required.")]
        [Range(0, 10000, ErrorMessage = "Game price should be between 0 to 10000")]
        public decimal Price { get; set; }
    }
}
