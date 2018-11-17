using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTrain.Entities.Functions
{
    public class DbFunction
    {
        [DbFunction(Schema = "dbo")]
        public static string ExampleFunction(string para)
        {
            throw new NotImplementedException();
        }
    }
}
