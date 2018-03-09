using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Review
    {
        public int ID { get; set; }

        public string Reviewer { get; set; }
        public string Comment { get; set; }
        public int MovieID { get; set; }
    }
}
