using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreTrain.Entities.Functions;
using EFCoreTrain.Entities.Views;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTrain.Entities
{
    public partial class BloggingContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDbFunction(() => DbFunction.ExampleFunction(default(string)));
        }

        public virtual DbSet<PostDetailView> PostDetail { get; set; }
    }
}
