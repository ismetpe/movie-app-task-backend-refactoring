using movie_app_task_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Data.Seeds
{
    public class MediaSeed
    {
        public static List<Media> Medias { get; } = new()
        {
            new Media
            {
                Id = 1,
                Title = "Star Wars: Return of the Jedi",
                Release_year = "1983-05-25",
                Description = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 2,
                Title = "Star Wars: A New Hope",
                Release_year = "1977-05-17",
                Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 3,
                Title = "Lord Of The Rings: The Two Towers",
                Release_year = "2002-12-18",
                Description = "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 4,
                Title = "The Hobbit: An Unexpected Journey",
                Release_year = "2012-12-13",
                Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 5,
                Title = "Brooklyn Nine-Nine",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 6,
                Title = "Lord Of The Rings: The Return Of The King",
                Release_year = "2013-09-17",
                Description = "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 7,
                Title = "The Hobbit: An Unexpected Journey",
                Release_year = "2013-09-17",
                Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 8,
                Title = "The Hobbit: The Desolation of Smaug",
                Release_year = "2013-12-12",
                Description = "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 9,
                Title = "The Hobbit: The Battle of the Five Armies",
                Release_year = "2014-12-11",
                Description = "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 10,
                Title = "Rick and Morty",
                Release_year = "2013-09-17",
                Description = "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 11,
                Title = "The Walking Dead",
                Release_year = "2010-10-31",
                Description = "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 12,
                Title = "Star Trek: Discovery",
                Release_year = "2017-09-24",
                Description = "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 13,
                Title = "Yellowstone",
                Release_year = "2018-06-20",
                Description = "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 14,
                Title = "The Flash",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 15,
                Title = "ELite",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 16,
                Title = "Vampire diaries",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 17,
                Title = "Lucifer",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 18,
                Title = "Marlon",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 19,
                Title = "Teen wolf",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 20,
                Title = "Invisible city",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 21,
                Title = "Locke is key",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 22,
                Title = "Fate",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 23,
                Title = "The Crew",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 24,
                Title = "Riverdale",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 25,
                Title = "The Ranch",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 26,
                Title = "Family guy",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 27,
                Title = "Cobra kai",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 28,
                Title = "Good Girls",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },


            new Media
            {
                Id = 29,
                Title = "The Witcher",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 30,
                Title = "Money heist",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 31,
                Title = "The Ranch",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 32,
                Title = "Just like heaven",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 33,
                Title = "Before I fall",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 34,
                Title = "The half of it",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 35,
                Title = "Endless love",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 36,
                Title = "Robin Hood",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 37,
                Title = "Aladdin",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 38,
                Title = "Gladiator",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 39,
                Title = "Defiance",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 40,
                Title = "POMS",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 41,
                Title = "Wonder",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 42,
                Title = "Transporter 3",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 43,
                Title = "Transporter 2",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 44,
                Title = "Transporter 1",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 45,
                Title = "Zoung adult",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 46,
                Title = "Shaft",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 47,
                Title = "Crash pad",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 48,
                Title = "Takers",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 49,
                Title = "Creed 3",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 50,
                Title = "Creed 2",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 51,
                Title = "Creed",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 52,
                Title = "Swiped",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 53,
                Title = "Hangover part 3",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 54,
                Title = "Hangover part 2",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 55,
                Title = "Hangover part 1",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 56,
                Title = "John Wick 3",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 57,
                Title = "John Wick 2",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 58,
                Title = "John Wick",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 59,
                Title = "The perfect date",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 60,
                Title = "Rudy",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 61,
                Title = "Just friends",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 62,
                Title = "Red 2",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 63,
                Title = "Pitch perfect",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 64,
                Title = "Work it",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 65,
                Title = "Kate",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 66,
                Title = "Grown ups 2",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 67,
                Title = "Grown ups",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 68,
                Title = "Blended",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 69,
                Title = "The Internship",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 70,
                Title = "Playing with fire",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 71,
                Title = "Monte Carlo",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 72,
                Title = "She is all that",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 73,
                Title = "47 ronin",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 74,
                Title = "Enola Holmes",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 75,
                Title = "Noah",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 76,
                Title = "In time",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 77,
                Title = "Midway",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 78,
                Title = "The Mask",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 79,
                Title = "Holidate",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 80,
                Title = "Warcraft",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 81,
                Title = "Tomb Raidler",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 82,
                Title = "Be somebody",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 83,
                Title = "Baywatch",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 84,
                Title = "Sweet girl",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 85,
                Title = "Good boys",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 86,
                Title = "Kong : skull island",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 87,
                Title = "Star trek",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 88,
                Title = "Journey 2",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 89,
                Title = "Constantine",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 90,
                Title = "Warrior nun",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 91,
                Title = "Merlin",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 92,
                Title = "The Walking Dead",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 93,
                Title = "Van Helsing",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 94,
                Title = "How I met your mother",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 95,
                Title = "Zero chill",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 96,
                Title = "Superman and Louise",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 97,
                Title = "Good witch",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 98,
                Title = "Shadow and Bone",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 99,
                Title = "Shadow hunters",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },


            new Media
            {
                Id = 100,
                Title = "Dare me",
                Release_year = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            }






        };
    }
}
