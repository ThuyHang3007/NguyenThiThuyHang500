using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiThuyHang500.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiThuyHang500.Models.UniversityNTTH500> UniversityNTTH500 { get; set; }

        public DbSet<NguyenThiThuyHang500.Models.NTTH0500> NTTH0500 { get; set; }
    }
