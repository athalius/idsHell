using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace auth.Models
{
    public class IdentityConfig
    {
        public string IdentityServerIdentityUrl { get; set; }
        public string AngularClientUrl { get; set; }
        //public string AngularClientIdTokenOnlyUrl { get; set; }
    }
}
