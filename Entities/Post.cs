﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite_BL.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; }

        public string? Content { get; set; }
        public DateTime? PublisedDateTime { get; set; }

        public int BlogId { get; set; }

        public Blog? Blog { get; set; }

        public virtual List<Comment>? Comments { get; set; }

    }
}
