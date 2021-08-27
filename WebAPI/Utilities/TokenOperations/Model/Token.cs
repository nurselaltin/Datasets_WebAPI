using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Utilities.TokenOperations.Model
{
    public class Token
    {

        public string AccessToken { get; set; }
        public DateTime Expiration { get; set; }


    }
}
