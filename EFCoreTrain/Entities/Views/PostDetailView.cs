using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTrain.Entities.Views
{
    public class PostDetailView
    {
        [Key]
        public int PostId { get; set; }
        public string AuthorName { get; set; }
    }
}
