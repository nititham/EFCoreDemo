using EFCoreTrain.Entities;
using Microsoft.EntityFrameworkCore;
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

        public List<Author> GetEndWith(string endText)
        {
            endText = $"%{endText}";
            return context.Author.Where(x => EF.Functions.Like(x.Name, endText)).ToList();
        }

        //Try to use transaction scope
        public void Insert(List<string> names)
        {
            var authors = new List<Author>();
            foreach (var name in names)
            {
                authors.Add(new Author { Name = name });
            }

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Author.AddRange(authors);
                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
