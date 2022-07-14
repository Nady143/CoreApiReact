using System;
using System.Collections.Generic;
using System.Text;
using Core.DomainLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.DataLayer.Context
{
    public class UniversityDBContext : DbContext
    {


        public UniversityDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
