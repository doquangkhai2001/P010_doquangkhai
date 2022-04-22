using System.ComponentModel.DataAnnotations;


namespace MvcMovie.News
{
    
    public class News
    {

        public int Id { get; set; }  
        public string? Title { get; set; } = String.Empty;
        [StringLength(200, MinimumLength = 50)]
        [Required]
        
        [System.ComponentModel.Bindable(true)]
        public virtual string ImageUrl { get; set; } = String.Empty;
        public int Content { get; set; } 
        [StringLength(500, MinimumLength = 100)]
        [Required]
        public int Author { get; set; }
        public int CreatedAt { get; set; }
    }
}
