using AutoConfiguratorApp.Models;
using System;
using System.Collections.Generic;

namespace AutoConfiguratorApp.Data
{
    public class MockAutoConfigRepo : IAutoConfiguratorRepo
    {
        public void CreateAutoConfiguration(AutoKonfiguration configItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteAutoConfiguration(AutoKonfiguration configItem)
        {
            throw new NotImplementedException();
        }

        public AutoKonfiguration GetAutoConfigurationById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AutoKonfiguration> GetAutoConfigurations()
        {
            throw new NotImplementedException();
            //var configs = new List<AutoKonfiguration>()
            //{ 
            //    new AutoKonfiguration{},
            //    new AutoKonfiguration{},
            //    new AutoKonfiguration{}
            //}

            //return configs;

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateAutoConfiguration(AutoKonfiguration configItem)
        {
            throw new NotImplementedException();
        }
    }
}
