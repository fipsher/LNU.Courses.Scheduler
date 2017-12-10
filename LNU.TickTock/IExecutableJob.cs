using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNU.TickTock
{
    public interface IExecutableJob
    {
        /// <summary>
        /// Run method
        /// </summary>
        /// <returns></returns>
        Task Execute();
    }
}
