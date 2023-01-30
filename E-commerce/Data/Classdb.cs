using E_commerce.Models;

namespace E_commerce.Data
{
    public class Classdb
    {
        private readonly DataBaseContx dataBase;

        public Classdb(DataBaseContx dataBase)
        {
            this.dataBase = dataBase;
        }

        public void Seed() 
        {
            
                

                if (!dataBase.Actors_Movies.Any()) 
                {

                var Actors_Movies = new List<Actors_Movies>()
                {
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actors_Movies()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actors_Movies()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actors_Movies()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actors_Movies()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actors_Movies()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actors_Movies()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    };
                dataBase.Actors_Movies.AddRange(Actors_Movies);
                dataBase.SaveChanges();
            }
            

        
                if (!dataBase.Actors.Any())
                {
                var Actor = new List<Actor>()
                {
                        new Actor()
                        {
                            Name = "Actor 1",
                            Description = "This is the Bio of the first actor",
                            PicUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            Name = "Actor 2",
                            Description = "This is the Bio of the second actor",
                            PicUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            Name = "Actor 3",
                            Description = "This is the Bio of the second actor",
                            PicUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            Name = "Actor 4",
                            Description = "This is the Bio of the second actor",
                            PicUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            Name = "Actor 5",
                            Description = "This is the Bio of the second actor",
                            PicUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    };
                dataBase.Actors.AddRange(Actor);
                dataBase.SaveChanges();

            }
                if (!dataBase.Movie.Any())
                {

                var Movie = new List<Movie>()
                {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            PicUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            Category = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            PicUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            Category = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            PicUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            Category = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            PicUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            Category = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            PicUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            Category = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            PicUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            Category = MovieCategory.Drama
                        }
                    };
                dataBase.Movie.AddRange(Movie);
                dataBase.SaveChanges();

            }
                if (!dataBase.Producer.Any())
                {
                var Producer = new List<Producer>()
                {
                        new Producer()
                        {
                            Name = "Producer 1",
                            Description = "This is the Bio of the first actor",
                            PicUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {Name = "Producer 2", Description = "This is the Bio of the second actor", PicUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"},
                        new Producer()
                        {
                            Name = "Producer 3",
                            Description = "This is the Bio of the second actor",
                            PicUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            Name = "Producer 4",
                            Description = "This is the Bio of the second actor",
                            PicUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            Name = "Producer 5",
                            Description = "This is the Bio of the second actor",
                            PicUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    };
                dataBase.Producer.AddRange(Producer);
                dataBase.SaveChanges();


            }
                if (!dataBase.Cinema.Any())
                {
                var Cinema = new List<Cinema>()
                {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            PicUrl = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            PicUrl = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            PicUrl = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            PicUrl = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            PicUrl = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    };
                dataBase.Cinema.AddRange(Cinema);
                dataBase.SaveChanges();

            }
            }

        }
   
    }

