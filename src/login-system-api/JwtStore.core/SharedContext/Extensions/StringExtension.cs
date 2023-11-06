using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JwtStore.core.SharedContext.Extensions
{
    public static class StringExtension
    {
        public static string ToBase64(this string text)
         => Convert.ToBase64String(Encoding.ASCII.GetBytes(text));
    }
}
