using MovieDB.UI.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MovieDB.ConApp
{
    interface IDataAccess<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    interface IDataMapper<TIn, TOut>
    {
        TOut Map(TIn obj);
    }
    abstract class JsonFileDataAccess<TDto, TDomain> : IDataAccess<TDomain>
    {
        private string jsonResponse;
        private IDataMapper<TDto, TDomain> mapper;
        public JsonFileDataAccess(string path, IDataMapper<TDto, TDomain> mapper)
        {
            this.mapper = mapper;
            jsonResponse = "[]";
        }
        public IEnumerable<TDomain> GetAll()
        {
            var dtoList = JsonConvert.DeserializeObject<List<TDto>>(jsonResponse);
            foreach (var item in dtoList)
            {
                yield return mapper.Map(item);
            }
        }
        public abstract TDomain GetById(int id);
    }
    class MovieJsonDataAccess : JsonFileDataAccess<Movie, MovieDomain>
    {
        private readonly IDataMapper<Movie, MovieDomain> _mapper;

        public MovieJsonDataAccess(IDataMapper<Movie, MovieDomain> mapper) 
            : base("path/to/my/jsonfile.json", mapper)
        {
            _mapper = mapper;
        }

        public override MovieDomain GetById(int id)
        {
            foreach (var item in GetAll())
            {
                if(item.MovieId == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
    class MovieDomain
    {
        public int MovieId { get; set; }
        public string Titulo { get; set; }
        public string ImgUrl { get; set; }
        public string Synopsis { get; set; }
        public string Genre { get; set; }

        public string HumanHash { get { return Titulo + MovieId; } }
    }
    class MovieMapper : IDataMapper<Movie, MovieDomain>
    {

        public MovieDomain Map(Movie obj)
        {
            var m = new MovieDomain();
            return m;
        }

    }


}
