using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class ReviewListViewModel
    {
        public List<Review> reviews;
        public string movieTitle { get; set; }
    }
}