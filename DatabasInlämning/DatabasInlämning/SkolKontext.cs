using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabasInlämning.Models;

namespace DatabasInlämning
{
    public class SkolKontext : DbContext
    {

        public DbSet<Elev> tblElever { get; set; }
        public DbSet<Kurs> tblKurser { get; set; }
        public DbSet<Läser> tblLäser { get; set; }
        public DbSet<Bok> tblBok { get; set; }
        public DbSet <BokLån> tblBokLån { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "server=localhost;user=school;password=school;database=school;";
            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );
        }
    }
}
