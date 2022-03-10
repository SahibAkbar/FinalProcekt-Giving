﻿using Giving__FinalProcekt_.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giving__FinalProcekt_.ViewModel
{
    public class VmUser
    {
        public List<CustomUser> CustomUsers { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public List<IdentityUserRole<string>> UserRoles { get; set; }
    }
}
