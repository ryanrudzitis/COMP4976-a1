using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Assignment1.Models
{
    public class XUser : IdentityUser
    {
        public XUser() : base() { }
        // public string? FirstName { get; set; }
        // public string? LastName { get; set; }
    }
}