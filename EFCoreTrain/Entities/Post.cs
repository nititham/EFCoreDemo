using System;
using System.Collections.Generic;

namespace EFCoreTrain.Entities
{
    public partial class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public Author Author { get; set; }
        public Blog Blog { get; set; }
    }
}
