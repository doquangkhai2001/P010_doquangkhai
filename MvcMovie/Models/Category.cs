using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Category
{
    public class Category
    {
        
        [StringLength(200, MinimumLength = 50)]
        [Required]
        
        [System.ComponentModel.Bindable(true)]
        public int Id { get; set; } = String.Empty;

        [System.ComponentModel.Bindable(true)]
        public string? Name { get; set; } = String.Empty;
        
        
    }
}