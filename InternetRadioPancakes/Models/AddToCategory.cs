using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetRadioPancakes.Models
{
    public class AddToCategory
    {
        public int categoryID { get; set; }
        public int postID { get; set; }
        public List<Post> posts { get; set; }

        public AddToCategory()
        {
            posts = new List<Post>();
        }
    }
}