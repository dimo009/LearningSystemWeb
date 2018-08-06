using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSystem.Data.Models
{
    public class MyRole : IdentityRole<int>
    {
        public MyRole() 
            : base()
        {

        }

        public MyRole(string roleName)
        {
            Name = roleName;
        }
    }
}
