using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class PdfDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server = (localdb)\\ProjectsV13 ; database = ConferenceDb ;integrated security=true;");


        }
        public DbSet<Pdf> Pdfs{ get; set; }

    }
}

