using System.ComponentModel.DataAnnotations;

namespace MvcMovie.comment
{
    public class comment
    { 
        [System.ComponentModel.Bindable(true)]
           public int Id { get; set; } 
        
        
      

      [System.ComponentModel.Bindable(true)]
        public int Content { get; set; }
        [System.ComponentModel.Bindable(true)]
        public int Author { get; set; }
        [System.ComponentModel.Bindable(true)]
        public int CreatedAt { get; set; }
        
    }
}