using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Maric
{
    public class LoggingProxyData : IDataset
    {
        private string filePath;
        private Dataset dataset;
        private ConsoleLogger logger;

        public LoggingProxyData(string filePath)
        {
            this.filePath = filePath;
            logger = new ConsoleLogger();
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }

        public void LogMessage(string message)
        {
            logger.LogMessage(message);
        }
    }
}
