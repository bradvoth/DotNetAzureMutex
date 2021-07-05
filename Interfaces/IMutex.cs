using System;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMutex : IDisposable
    {
        public Task Lock(int duration);
        public Task Renew(int duration);
        public Task Release();
    }
}