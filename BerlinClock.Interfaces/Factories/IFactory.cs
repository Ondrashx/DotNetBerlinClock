using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Interfaces.Factories
{
    public interface IFactory<T>
    {
        /// <summary>
        /// Creates an instance of T
        /// </summary>
        /// <returns></returns>
        T Create();
    }
}
