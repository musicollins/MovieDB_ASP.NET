﻿using Newtonsoft.Json;
using System;

namespace MovieDB.UI.Model
{
    public class Movie
    {

        [JsonProperty("movie_id")]
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string Synopsis { get; set; }
        public Genre Genre{ get; set; }
    }

    public enum Genre
    {
        HORROR,
        COMEDY,
        DRAMA,
        ANIMATION

    }
}
