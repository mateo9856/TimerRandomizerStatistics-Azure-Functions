using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using RandomizeLogic;

namespace RandomizerTrigger
{
    public class RandomizerTrigger
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 * */12 * * *")]TimerInfo myTimer, ILogger log)
        {
            var data = new CsvData();
            var datas = data.ReadStatisticsData();
            foreach(var val in datas)
            {
                log.LogInformation(val.ToString());
            }
        }
    }
}
