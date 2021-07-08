using System;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMutex : IDisposable
    {
        /// <summary>
        /// Acquire an exclusive lock for seconds duration
        /// </summary>
        /// <param name="duration">seconds</param>
        /// <returns></returns>
        public Task Lock(int duration);
        
        /// <summary>
        /// Renew a lock for an additional seconds duration
        /// </summary>
        /// <param name="duration">seconds</param>
        /// <returns></returns>
        public Task Renew(int duration);
        
        /// <summary>
        /// Release a given lock
        /// </summary>
        /// <returns></returns>
        public Task Release();
    }
}