﻿using ABCSchool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ABCSchool.Data
{
    public class AbcSchoolDbContext : DbContext
    {
        public AbcSchoolDbContext(DbContextOptions<AbcSchoolDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Subject>()
                .HasData(
                    new Subject()
                    {
                        Id = 1,
                        Name = "English"
                    },
                    new Subject()
                    {
                        Id = 2,
                        Name = "Maths"
                    },
                    new Subject()
                    {
                        Id = 3,
                        Name = "Spanish"
                    },
                    new Subject()
                    {
                        Id = 4,
                        Name = "Biology"
                    },
                    new Subject()
                    {
                        Id = 5,
                        Name = "Science"
                    },
                    new Subject()
                    {
                        Id = 6,
                        Name = "Programming"
                    },
                    new Subject()
                    {
                        Id = 7,
                        Name = "Law"
                    },
                    new Subject()
                    {
                        Id = 8,
                        Name = "Commerce"
                    },
                    new Subject()
                    {
                        Id = 9,
                        Name = "Physical Education"
                    });
        }        
    }    
}
