using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int CinemaId { get; set; }
        public string Name { get;set; }
        public string PicUrl { get; set; }    
        public string Description { get; set; }   
        public List<Movie> Movies { get; set; }
    }
}
