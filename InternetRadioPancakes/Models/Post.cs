using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetRadioPancakes.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public string Category { get; set; }
        public int Views { get; set; }
        public string ImageUrl { get; set; }

        public DateTime addedTime { get; set; }

        public Post()
        {
            addedTime = DateTime.Now;
            Views = 0;
        }
        public bool Equals(string title)
        {
            if (this.Title == title)
                return true;
            return false;
        }
    }
    

}