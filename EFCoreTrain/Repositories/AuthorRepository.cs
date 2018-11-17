using EFCoreTrain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTrain.Repositories
{
    public class AuthorRepository
    {
        private readonly BloggingContext context;
        public AuthorRepository(BloggingContext context)
        {
            this.context = context;
        }

        public Author Get()
        {
            return context.Author.FirstOrDefault();
        }
    }
}
