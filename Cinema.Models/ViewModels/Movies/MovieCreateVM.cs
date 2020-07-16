﻿using Microsoft.AspNetCore.Http;

namespace Cinema.Models.ViewModels.Movies
{
    public class MovieCreateVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string VideoLink { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}