using System;
using System.Collections.Generic;

namespace EFCoreTrain.Entities
{
    public partial class Author
    {
        public Author()
        {
            Post = new HashSet<Post>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
