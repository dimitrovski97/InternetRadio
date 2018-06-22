using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetRadioPancakes.Models
{
    public class Category
    {        
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<Post> Posts  { get; set; }
        public Category()
        {
            Posts = new List<Post>();
        }
       

    }
}