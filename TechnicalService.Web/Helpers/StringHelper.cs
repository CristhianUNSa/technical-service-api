using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalService.Web.Helpers
{
    public class StringHelper
    {
        public static string Get5CharacterRandomString()
        {
            string path = System.IO.Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path.Substring(0, 5); 
        }
    }
}
