using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Assignment1.Models
{
    public class XRole : IdentityRole
    {
        public XRole() : base() { }
        public XRole(string roleName) : base(roleName) { }
        public XRole(string roleName, DateTime createdDate) : base(roleName)
        {
            base.Name = roleName;
            this.CreatedDate = createdDate;
        }
        public DateTime CreatedDate { get; set; }
    }
}