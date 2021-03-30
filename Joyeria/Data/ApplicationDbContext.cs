using Joyeria.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Joyeria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<JewelleryType> JewelleryTypes { get; set; }
        public DbSet<GenderType> GenderTypes { get; set; }
        public DbSet<JewelleryInfo> JewelleryInfos { get; set; }
        public DbSet<JewelleryReview> JewelleryReviews { get; set; }
    }
}
