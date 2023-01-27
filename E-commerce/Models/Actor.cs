using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
    public class Actor
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string PicUrl { get; set; }
        public string Name { get;set; }
        public string Description { get;set; }
        public List<Actors_Movies> Actor_Movies { get; set; }
        
    }
}
