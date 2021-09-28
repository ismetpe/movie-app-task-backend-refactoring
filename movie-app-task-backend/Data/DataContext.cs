using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Models;
using System.Text;

namespace movie_app_task_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Media> Medias { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<MostRatedMoviesReport> MostRatedMoviesReports { get; set; }
        public DbSet<MostScreenedMoviesReport> MoviesWithMostScreeningsReports { get; set; }
        public DbSet<MovieWithMostSoldTicketsReport> MoviesWithMostSoldTicketsReports { get; set; }
        public DbSet<PurchasedTicket> PurchasedTickets { get; set; }

        public object MostScreenedMoviesReports { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {  
            modelBuilder.Entity<Media>().HasData(

              new Media
              {
                  Id = 1,
                  Title = "Star Wars: Return of the Jedi",
                  Release_year = "1983-05-25",
                  Description = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.",
                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                  isSeries = false,

              },
                              new Media
                              {
                                  Id = 2,
                                  Title = "Star Wars: A New Hope",
                                  Release_year = "1977-05-17",
                                  Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 3,
                                  Title = "Lord Of The Rings: The Two Towers",
                                  Release_year = "2002-12-18",
                                  Description = "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 4,
                                  Title = "The Hobbit: An Unexpected Journey",
                                  Release_year = "2012-12-13",
                                  Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 5,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },                              new Media
                              {
                                  Id = 6,
                                  Title = "Lord Of The Rings: The Return Of The King",
                                  Release_year = "2013-09-17",
                                  Description = "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 7,
                                  Title = "The Hobbit: An Unexpected Journey",
                                  Release_year = "2013-09-17",
                                  Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 8,
                                  Title = "The Hobbit: The Desolation of Smaug",
                                  Release_year = "2013-12-12",
                                  Description = "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 9,
                                  Title = "The Hobbit: The Battle of the Five Armies",
                                  Release_year = "2014-12-11",
                                  Description = "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162",
                                  isSeries = false,

                              },                              new Media
                              {
                                  Id = 10,
                                  Title = "Rick and Morty",
                                  Release_year = "2013-09-17",
                                  Description = "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 11,
                                  Title = "The Walking Dead",
                                  Release_year = "2010-10-31",
                                  Description = "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 12,
                                  Title = "Star Trek: Discovery",
                                  Release_year = "2017-09-24",
                                  Description = "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 13,
                                  Title = "Yellowstone",
                                  Release_year = "2018-06-20",
                                  Description = "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 14,
                                  Title = "The Flash",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 15,
                                  Title = "ELite",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 16,
                                  Title = "Vampire diaries",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 17,
                                  Title = "Lucifer",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 18,
                                  Title = "Marlon",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 19,
                                  Title = "Teen wolf",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 20,
                                  Title = "Invisible city",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 21,
                                  Title = "Locke is key",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 22,
                                  Title = "Fate",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 23,
                                  Title = "The Crew",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 24,
                                  Title = "Riverdale",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 25,
                                  Title = "The Ranch",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                                new Media
                              {
                                  Id = 26,
                                  Title = "Family guy",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },

                              new Media
                              {
                                  Id = 27,
                                  Title = "Cobra kai",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },

                              new Media
                              {
                                  Id = 28,
                                  Title = "Good Girls",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },


                              new Media
                              {
                                  Id = 29,
                                  Title = "The Witcher",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              new Media
                              {
                                  Id = 30,
                                  Title = "Money heist",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },

                              new Media
                              {
                                  Id = 31,
                                  Title = "The Ranch",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },

                              new Media
                              {
                                  Id = 32,
                                  Title = "Just like heaven",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 33,
                                  Title = "Before I fall",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 34,
                                  Title = "The half of it",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 35,
                                  Title = "Endless love",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 36,
                                  Title = "Robin Hood",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 37,
                                  Title = "Aladdin",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 38,
                                  Title = "Gladiator",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 39,
                                  Title = "Defiance",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 40,
                                  Title = "POMS",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 41,
                                  Title = "Wonder",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 42,
                                  Title = "Transporter 3",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 43,
                                  Title = "Transporter 2",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 44,
                                  Title = "Transporter 1",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 45,
                                  Title = "Zoung adult",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 46,
                                  Title = "Shaft",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 47,
                                  Title = "Crash pad",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 48,
                                  Title = "Takers",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 49,
                                  Title = "Creed 3",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 50,
                                  Title = "Creed 2",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 51,
                                  Title = "Creed",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 52,
                                  Title = "Swiped",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 53,
                                  Title = "Hangover part 3",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 54,
                                  Title = "Hangover part 2",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 55,
                                  Title = "Hangover part 1",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 56,
                                  Title = "John Wick 3",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 57,
                                  Title = "John Wick 2",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 58,
                                  Title = "John Wick",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 59,
                                  Title = "The perfect date",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 60,
                                  Title = "Rudy",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 61,
                                  Title = "Just friends",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 62,
                                  Title = "Red 2",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 63,
                                  Title = "Pitch perfect",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 64,
                                  Title = "Work it",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 65,
                                  Title = "Kate",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 66,
                                  Title = "Grown ups 2",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 67,
                                  Title = "Grown ups",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 68,
                                  Title = "Blended",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 69,
                                  Title = "The Internship",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 70,
                                  Title = "Playing with fire",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 71,
                                  Title = "Monte Carlo",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 72,
                                  Title = "She is all that",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 73,
                                  Title = "47 ronin",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 74,
                                  Title = "Enola Holmes",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 75,
                                  Title = "Noah",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 76,
                                  Title = "In time",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 77,
                                  Title = "Midway",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 78,
                                  Title = "The Mask",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 79,
                                  Title = "Holidate",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 80,
                                  Title = "Warcraft",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 81,
                                  Title = "Tomb Raidler",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 82,
                                  Title = "Be somebody",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 83,
                                  Title = "Baywatch",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 84,
                                  Title = "Sweet girl",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 85,
                                  Title = "Good boys",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 86,
                                  Title = "Kong : skull island",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 87,
                                  Title = "Star trek",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },

                              new Media
                              {
                                  Id = 88,
                                  Title = "Journey 2",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },
                              new Media
                              {
                                  Id = 89,
                                  Title = "Constantine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              },


                              new Media
                              {
                                  Id = 90,
                                  Title = "Warrior nun",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 91,
                                  Title = "Merlin",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 92,
                                  Title = "The Walking Dead",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 93,
                                  Title = "Van Helsing",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 94,
                                  Title = "How I met your mother",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 95,
                                  Title = "Zero chill",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 96,
                                  Title = "Superman and Louise",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 97,
                                  Title = "Good witch",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 98,
                                  Title = "Shadow and Bone",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },
                              
                              new Media
                              {
                                  Id = 99,
                                  Title = "Shadow hunters",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              },


                              new Media
                              {
                                  Id = 100,
                                  Title = "Dare me",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = true,

                              }






            );
             

            modelBuilder.Entity<Actor>().HasData(
              new Actor { Id = 1, Name = "Chris Hemsworth"},
              new Actor { Id = 2, Name = "Natalie Portman" },
              new Actor { Id = 3, Name = "Tom Hiddleston" },
 new Actor     {
         Id = 4,
         Name = "Brianna Howe"
      },
 new Actor     {
         Id = 5,
        Name = "Carver Wong"
      },
 new Actor     {
         Id = 6,
        Name= "James Hines"
      },
 new Actor     {
         Id = 7,
         Name = "Leon Jarvis"
      },
  new Actor    {
         Id = 8,
         Name = "Vinson Moran"
      },
  new Actor    {
         Id = 9,
         Name = "Simpson Evans"
      },
 new Actor     {
        Id =10,
         Name = "Henry Molina"
      },
 new Actor     {
         Id = 11,
        Name = "Mccullough Curry"
      },
  new Actor    {
         Id = 12,
         Name = "Angelia Ruiz"
      },
   new Actor   {
         Id = 13,
         Name = "Hinton Love"
      },
         new Actor   {
         Id = 14,
         Name = "Adrienne Logan"
      },
  new Actor    {
        Id = 15,
         Name = "Broderick Moore"
      },
        new Actor    {
        Id = 16,
         Name = "Saundra West"
      },
        new Actor    {
        Id = 17,
         Name = "Alisha Bentley"
      },
        new Actor    {
        Id = 18,
         Name = "Hiram Strickland"
      },
        new Actor    {
        Id = 19,
         Name = "Larry Garcia"
      },
        new Actor    {
        Id = 20,
         Name = "Deshawn Arias"
      },
        new Actor    {
        Id = 21,
         Name = "Miriam Cummings"
      },
        new Actor    {
        Id = 22,
         Name = "Normand Hughes"
      },
        new Actor    {
        Id = 23,
         Name = "Modesto Clements"
      },
        new Actor    {
        Id = 24,
         Name = "Rey Romero"
      },
        new Actor    {
        Id = 25,
         Name = "Alec Davila"
      },
        new Actor    {
        Id = 26,
         Name = "Nellie Barr"
      },
        new Actor    {
        Id = 27,
         Name = "Odell Best"
      },
        new Actor    {
        Id = 28,
         Name = "Bradly Obrien"
      },
        new Actor    {
        Id = 29,
         Name = "Demarcus Boyle"
      },
        new Actor    {
        Id = 30,
         Name = "Walter Blankenship"
      },
        new Actor    {
        Id = 31,
         Name = "Dwayne Wun"
      },
        new Actor    {
        Id = 32,
         Name = "Carlos Ross"
      },
        new Actor    {
        Id = 33,
         Name = "Melissa Schwartz"
      },
        new Actor    {
        Id = 34,
         Name = "Scottie Fleming"
      },
        new Actor    {
        Id = 35,
         Name = "Mara Baldwin"
      },
        new Actor    {
        Id = 36,
         Name = "Kristina Hardy"
      },
        new Actor    {
        Id = 37,
         Name = "Chris Brandt"
      },
        new Actor    {
        Id = 38,
         Name = "Alva Compton"
      },
        new Actor    {
        Id = 39,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 40,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 41,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 42,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 43,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 44,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 45,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 46,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 47,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 48,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 49,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 50,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 51,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 52,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 53,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 54,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 55,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 56,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 57,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 58,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 59,
         Name = "Victoria Alston"
      },
        new Actor    {
        Id = 60,
         Name = "Victoria Alston"
      },  new Actor    {
        Id = 61,
         Name = "Victoria Alston"
      }

              );



            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = 1, Rating_value = 4.6F, MediaId = 1},
                new Rating { Id = 2, Rating_value = 4.5F, MediaId = 2 },
                new Rating { Id = 3, Rating_value = 4.5F, MediaId = 3 },
                new Rating { Id = 4, Rating_value = 4.5F, MediaId = 4},
                new Rating { Id = 5, Rating_value = 4.6F, MediaId = 5},
                new Rating { Id = 6, Rating_value = 4.5F, MediaId = 6 },
                new Rating { Id = 7, Rating_value = 4.5F, MediaId = 7 },
                new Rating { Id = 8, Rating_value = 4.5F, MediaId = 8},
                                
                new Rating { Id = 9, Rating_value = 4.6F, MediaId = 9},
                new Rating { Id = 10, Rating_value = 4.5F, MediaId = 10 },
                new Rating { Id = 11, Rating_value = 4.5F, MediaId = 11 },
                new Rating { Id = 12, Rating_value = 4.5F, MediaId = 12},
                new Rating { Id = 13, Rating_value = 4.6F, MediaId = 13},
                new Rating { Id = 14, Rating_value = 4.5F, MediaId = 14 },
                new Rating { Id = 15, Rating_value = 4.5F, MediaId = 15 },
                new Rating { Id = 16, Rating_value = 4.5F, MediaId = 16},



                new Rating { Id = 17, Rating_value = 4.6F, MediaId = 17},
                new Rating { Id = 18, Rating_value = 4.5F, MediaId = 18},
                new Rating { Id = 19, Rating_value = 4.5F, MediaId = 19},
                new Rating { Id = 20, Rating_value = 4.5F, MediaId = 20},
                new Rating { Id = 21, Rating_value = 4.6F, MediaId = 21},
                new Rating { Id = 22, Rating_value = 4.5F, MediaId = 22},
                new Rating { Id = 23, Rating_value = 4.5F, MediaId = 23},
                new Rating { Id = 24, Rating_value = 4.5F, MediaId = 24}
            
            );
            modelBuilder.Entity<Screening>().HasData(
                    new Screening { Id = 1, Date = System.DateTime.Now.AddDays(100).AddHours(100).AddMinutes(100), MediaId=1, Number_of_seats = 100,Number_of_tickets=100, Place="Sarajevo",Time="10:00" },
                    new Screening { Id = 2, Date = System.DateTime.Now.AddDays(10), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 3, Date = System.DateTime.Now.AddDays(8), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "08:00" },
                    new Screening { Id = 4, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "09:00" },
                    new Screening { Id = 5, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "10:00" },
                    new Screening { Id = 6, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "00:00" },
                    new Screening { Id = 7, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "23:00" },
                    new Screening { Id = 8, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "22:00" },
                    new Screening { Id = 9, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "21:00" },
                    new Screening { Id = 11, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "20:00" },
                    new Screening { Id = 12, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "19:00" },
                    new Screening { Id = 13, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "18:00" },
                    new Screening { Id = 14, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "17:00" }, 
                    new Screening { Id = 15, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "16:00" },
                    new Screening { Id = 16, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "15:00" }, 
                    new Screening { Id = 17, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "14:00" },
                    new Screening { Id = 18, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "13:00" },
                    new Screening { Id = 19, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "12:00" },
                    new Screening { Id = 20, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 21, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 22, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 23, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 24, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

                    new Screening { Id = 25, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 26, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 27, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 28, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 29, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },


                    new Screening { Id = 30, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 31, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 32, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 33, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 34, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },



                    new Screening { Id = 35, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 36, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 37, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 38, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 39, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },


                    new Screening { Id = 40, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 41, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 42, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 43, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 44, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },



                    new Screening { Id = 45, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 46, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 47, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 48, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 49, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },



                    new Screening { Id = 50, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 51, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 52, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 53, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 54, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

                    new Screening { Id = 55, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 56, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 57, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 58, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 59, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

                    new Screening { Id = 60, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 61, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 62, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 63, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 64, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

                    new Screening { Id = 65, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 66, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 67, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 68, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
                    new Screening { Id = 69, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" }
                );
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "user1", Password = "123456" },
                new User { Id = 2, Username = "user2", Password = "123456" },
                new User { Id = 3, Username = "user3", Password = "123456" },
                new User { Id = 4, Username = "user4", Password = "123456" },
                new User { Id = 5, Username = "user5", Password = "123456" }

                );

            modelBuilder.Entity<PurchasedTicket>().HasData(
                    new PurchasedTicket { Id = 1, Price = 5.5F, ScreeningId = 1 , UserId = 1 },
                    new PurchasedTicket { Id = 2, Price = 5.5F, ScreeningId = 25, UserId = 1 },
                    new PurchasedTicket { Id = 3, Price = 5.5F, ScreeningId = 30, UserId = 1 },
                    new PurchasedTicket { Id = 4, Price = 5.5F, ScreeningId = 35, UserId = 1 },
                    new PurchasedTicket { Id = 5, Price = 5.5F, ScreeningId = 40, UserId = 1 },
                    new PurchasedTicket { Id = 6, Price = 5.5F, ScreeningId = 45, UserId = 1 },
                    new PurchasedTicket { Id = 7, Price = 5.5F, ScreeningId = 50, UserId = 1 },
                    new PurchasedTicket { Id = 8, Price = 5.5F, ScreeningId = 55, UserId = 1 },
                    new PurchasedTicket { Id = 9, Price = 5.5F, ScreeningId = 60, UserId = 1 },
                    new PurchasedTicket { Id = 10, Price = 5.5F, ScreeningId = 65, UserId = 2 }
                );


            modelBuilder.Entity<Ticket>().HasData(
        new Ticket { Id = 1, Price = 5.5F, ScreeningId = 1  },
        new Ticket { Id = 2, Price = 5.5F, ScreeningId = 25 },
        new Ticket { Id = 3, Price = 5.5F, ScreeningId = 30 },
        new Ticket { Id = 4, Price = 5.5F, ScreeningId = 35 },
        new Ticket { Id = 5, Price = 5.5F, ScreeningId = 40 },
        new Ticket { Id = 6, Price = 5.5F, ScreeningId = 45 },
        new Ticket { Id = 7, Price = 5.5F, ScreeningId = 50 },
        new Ticket { Id = 8, Price = 5.5F, ScreeningId = 55 },
        new Ticket { Id = 9, Price = 5.5F, ScreeningId = 60 },
        new Ticket { Id = 10, Price = 5.5F,ScreeningId = 65 }
    );



            /*            string GetMoviesWithMostSoldTicketsWithoutRating = @" CREATE PROCEDURE GetMoviesWithMostSoldTicketsWithoutRating
                                                             AS
                                                             BEGIN
                                                             SET NOCOUNT ON

                                                             SELECT  m.Id, m.Title, s.Id AS Screening,COUNT(t.Id) AS Sold_tickets
                                                             FROM Medias m
                                                             JOIN Screenings s ON s.MediaId = m.Id
                                                             JOIN Tickets t ON t.ScreeningId = s.Id
                                                             WHERE (    SELECT COUNT(*) 
                                                                        FROM Ratings r 
                                                                        WHERE r.MediaId = m.Id ) = 0
                                                             AND isSeries = 0
                                                             GROUP BY m.Id,m.Title,s.Id
                                                             ORDER BY Count(t.Id) DESC;

                                                             END";

            string GetTopTenMoviesWithMostRating = @"CREATE PROCEDURE GetTopTenMoviesWithMostRating
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON

                                             SELECT TOP 10  m.Id, m.Title, Count(r.MediaId) as NumberOfRatings, avg(r.rating_value) AS Movie_rating 
                                             FROM Medias m 
                                             JOIN Ratings r On r.MediaId = m.Id
                                             WHERE isSeries = 0 
                                             GROUP BY m.Id, Title
                                             ORDER BY avg(r.rating_value) DESC;

                                             END";




            string GetTopTenMoviesWithMostScreening = @"CREATE PROCEDURE GetTopTenMoviesWithMostScreening
                                             @start_date DateTime,@end_date DateTime
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON

                                             SELECT TOP 10  m.Id, m.Title, Count(s.Id) as NumberOfScreenings
                                             FROM Medias m 
                                             JOIN Screenings s On s.MediaId = m.Id
                                             WHERE s.Date BETWEEN @start_date AND @end_date AND isSeries = 0
                                             GROUP BY m.Id, Title
                                             ORDER BY Count(s.Id) DESC;

                                              END";
            migrationBuilder.Sql(GetMoviesWithMostSoldTicketsWithoutRating);
            migrationBuilder.Sql(GetTopTenMoviesWithMostRating);
            migrationBuilder.Sql(GetTopTenMoviesWithMostScreening);*/
            modelBuilder.Entity<MostRatedMoviesReport>().HasNoKey();
            modelBuilder.Entity<MostScreenedMoviesReport>().HasNoKey();
            modelBuilder.Entity<MovieWithMostSoldTicketsReport>().HasNoKey();
        }
    }
}