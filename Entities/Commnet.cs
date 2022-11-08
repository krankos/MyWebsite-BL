using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite_BL.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? Author { get; set; }

        public int PostId { get; set; }

        public Post? Post { get; set; }


    }
}
