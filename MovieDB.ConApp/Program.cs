using Autofac;
using MovieDB.ConApp.DataAccess;
using MovieDB.ConApp.Startup;
using MovieDB.ConApp.Views;
using MovieDB.UI.DataSource;
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
            //MoviesModel viewModel = 
            //    new MoviesModel(
            //        new MoviesDataAccessJson(
            //            new DataSource_Json()));

            var diContainer = new DiContainer();
            var viewModel = diContainer.Container().Resolve<MoviesModel>();

            foreach (var movie in viewModel.Movies)
            {
                Console.WriteLine(movie.Title);
            }

        }
    }
}




//var path = @"C:\Users\Demiurgos\source\repos\MovieDB\MovieDB.ConApp\movies.json";
//var json = File.ReadAllText(path);
//var movies = JsonConvert.DeserializeObject<List<Movie>>(json);
//foreach (var movie in movies)
//{
//    Console.WriteLine(movie.Title);
//}