using System;
using System.Collections.Generic;
using System.Text;
using BridegeManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BridegeManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Bridge> Bridges { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<Damage> Damages { get; set; }

    }
}

