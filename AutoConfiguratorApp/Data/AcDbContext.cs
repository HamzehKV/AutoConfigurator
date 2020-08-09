using AutoConfiguratorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AutoConfiguratorApp.Data

{
    public class AcDbContext :DbContext
    {
        public AcDbContext(DbContextOptions<AcDbContext> options) :base(options)
        {

        }
        public DbSet<AutoConfiguration> ConfigItem { get; set; }
    }
}
