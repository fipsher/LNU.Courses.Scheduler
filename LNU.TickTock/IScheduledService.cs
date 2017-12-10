using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNU.TickTock
{
    public interface IScheduledService
    {
        /// <summary>
        /// Check is it a time to start deadline logic
        /// </summary>
        /// <returns>
        /// None if time is not came. 
        /// First if it is a time to launch First deadline logic.
        /// Second if it is a time to launch Second deadline job
        /// </returns>
        Task<Enums.DeadlineType> Check();


        /// <summary>
        /// Run deadline job
        /// </summary>
        /// <param name="job">First of second deadline job</param>
        /// <returns></returns>
        Task Run(IExecutableJob job);
    }
}
