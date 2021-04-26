using AnimeManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeManager.Core.Data
{
    public class AnimeManagerDbContext : DbContext
    {
        public DbSet<ProjectModel> ProjectModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Directory.CreateDirectory("Data");
            optionsBuilder.UseSqlite(@"Data Source=Data/AnimeManager.db");
        }
    }
}
