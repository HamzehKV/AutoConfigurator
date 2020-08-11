using AutoConfiguratorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoConfiguratorApp.Data
{
    public class SqlAutoConfiguratorRepo : IAutoConfiguratorRepo
    {
        private readonly AkDbContext _context;

        public SqlAutoConfiguratorRepo(AkDbContext context)
        {
            _context = context;
        }
        public void CreateAutoConfiguration(AutoKonfiguration configItem)
        {
            if (configItem == null)
            {
                throw new ArgumentNullException(nameof(configItem));
            }
            _context.AutoKonfigurationen.Add(configItem);
        }

        public void DeleteAutoConfiguration(AutoKonfiguration configItem)
        {
            if (configItem == null)
            {
                throw new ArgumentNullException(nameof(configItem));
            }
            _context.AutoKonfigurationen.Remove(configItem);
        }

        public AutoKonfiguration GetAutoConfigurationById(int id)
        {
            return _context.AutoKonfigurationen.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<AutoKonfiguration> GetAutoConfigurations()
        {
            return _context.AutoKonfigurationen.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateAutoConfiguration(AutoKonfiguration configItem)
        {
            throw new NotImplementedException();
        }
    }
}
