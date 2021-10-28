using MovieDB.UI.Model;
using System;
using System.Collections.Generic;

namespace MovieDB.UI.DataSource
{
    public class DataSource_Mockdata :IDataSource
    {
        public List<Movie> Movies { get; set; }
        public DataSource_Mockdata()
        {
            Movies = new List<Movie>()
            {
                new Movie(){
                    MovieId = Guid.NewGuid(),
                    Title="The Shining",
                    Genre=Genre.HORROR,
                    Synopsis="Writer Jack Torrance takes a job as a winter caretaker of the Overlook Hotel in the remote Colorado mountains. He moves in, along with his wife Wendy and son Danny, in the hope that the isolation will cure his writer’s block. But as the weather isolates them, Jack descends into madness. And then apparitions from the hotel’s past appear, imploring Jack to kill his family.",
                    ImgUrl = "https://pics.filmaffinity.com/the_shining-453129380-large.jpg"},
                new Movie()
                {
                    MovieId = Guid.NewGuid(),
                    Title = "Ran",
                    Genre = Genre.DRAMA,
                    Synopsis = "A reinterpretation of William Shakespeare's 'King Lear'. The Lear counterpart is an elderly 16th-century warlord (Tatsuya Nakadai), who announces that he's about to divide his kingdom equally among his three sons. In his dotage, he falls prey to the false flattery of his treacherous sons (Akira Terao and Jinpachi Nezu), while banishing his youngest son (Daisuke Ryu), the only member of the family who loves him enough to tell him the unvarnished truth. Thanks to his foolish pride, his domain collapses under its own weight as the sons battle each other over total control.",
                    ImgUrl = "https://pics.filmaffinity.com/ran-397228667-large.jpg"
                },
                new Movie()
                {
                    MovieId = Guid.NewGuid(),
                    Title = "Fight Club",
                    Genre = Genre.COMEDY,
                    Synopsis = "A nameless disillusioned young urban male (Edward Norton) fights insomnia by attending disease support groups until he meets a kindred spirit -and soap salesman (Brad Pitt). Together they form Fight Club, where young men can exert their frustrations and angst upon one another.",
                    ImgUrl = "https://pics.filmaffinity.com/fight_club-320750671-large.jpg"
                },
                new Movie()
                {
                    MovieId = Guid.NewGuid(),
                    Title = "The Adventures of Picasso",
                    Genre = Genre.COMEDY,
                    Synopsis = "Already in his childhood, Pablo Picasso shows talent for painting and is sent to the Academy of Arts in Madrid. He becomes a painter but has to live in Paris in poverty. But one day he is discovered by a rich American millionaire and starts to earn money. But he wastes his talent by painting plates. He meets the famous people of the 1920s; Gertrude Stein, Alice B. Toklas, Appolinaire, Hitler and Churchill",
                    ImgUrl = "https://pics.filmaffinity.com/picassos_aventyr-145972801-large.jpg"
                }
            };
        }

        public List<Movie> GetAll()
        {
            return Movies;
        }

        public Movie GetById(Guid id)
        {
            return Movies.Find(m => m.MovieId == id);
        }

        public void RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
