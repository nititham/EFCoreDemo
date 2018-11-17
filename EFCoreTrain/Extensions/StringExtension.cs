using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTrain.Extensions
{
    public static class StringExtension
    {
        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value) == false;
        }
    }
}
