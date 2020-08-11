using AutoConfiguratorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoConfiguratorApp.Data
{
    public interface IAutoConfiguratorRepo
    {
        bool SaveChanges();

        IEnumerable<AutoKonfiguration> GetAutoConfigurations();
        AutoKonfiguration GetAutoConfigurationById(int id);
        void CreateAutoConfiguration(AutoKonfiguration configItem);
        void UpdateAutoConfiguration(AutoKonfiguration configItem);
        void DeleteAutoConfiguration(AutoKonfiguration configItem);

    }
}
