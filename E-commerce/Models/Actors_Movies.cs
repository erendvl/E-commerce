namespace E_commerce.Models
{
    public class Actors_Movies
    {
        public int ActorId { get; set; }    
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
