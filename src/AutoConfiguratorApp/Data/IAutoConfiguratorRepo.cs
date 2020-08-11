using AutoConfiguratorApp.Models;
using System.Collections.Generic;

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
