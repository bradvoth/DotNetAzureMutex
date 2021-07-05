using System.Threading.Tasks;
using Interfaces;
using Microsoft.Azure.Cosmos;

namespace CosmosMutex
{
    public class AzureMutex : IMutex
    {
        public AzureMutex(Container lockContainer, string lockId)
        {
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task Lock(int duration)
        {
            throw new System.NotImplementedException();
        }

        public Task Renew(int duration)
        {
            throw new System.NotImplementedException();
        }

        public Task Release()
        {
            throw new System.NotImplementedException();
        }
    }
}