using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPR_PART_2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace APPR_PART_2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SampleUser class
public class SampleUser : IdentityUser
{
    public string Firstname { get; set; }
    
}

