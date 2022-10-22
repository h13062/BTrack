using BabyTracker.Core.Contract.Service;
using BabyTracker.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Infrastructure.Service
{
    public class BabyServiceAsync : IBabyServiceAsync
    {
        public Task<int> AddBabyAsync(BabyModel baby)
        {
            throw new NotImplementedException();
        }

        public Task<int?> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BabyModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BabyModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BabyModel> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateBabyAsync(BabyModel baby)
        {
            throw new NotImplementedException();
        }
    }
}
