using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechnicalService.Web.Models;

namespace TechnicalService.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ServiceItem> ServiceItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
