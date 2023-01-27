using E_commerce.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Description { get; set; }
        public string PicUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }  
        public string Actors { get; set; }
        public string CinemaName { get; set; }
        public MovieCategory Category { get; set; }
        public List<Actors_Movies> Actor_Movies { get; set; }


        public Cinema Cinema { get; set; }

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }

        public Producer Producer { get; set; }

        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
        
    }
}
