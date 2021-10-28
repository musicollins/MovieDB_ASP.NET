using MovieDB.UI.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MovieDB.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Demiurgos\source\repos\MovieDB\MovieDB.ConApp\movies.json";
            var json = File.ReadAllText(path);
            var movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
            }




        }
    }
}
