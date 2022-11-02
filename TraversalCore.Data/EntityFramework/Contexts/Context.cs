﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Data.EntityFramework.Contexts
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact>  Contacts { get; set; }
        public DbSet<Destination>  Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=TraversalDb;integrated security=true;");
        }
    }
}
