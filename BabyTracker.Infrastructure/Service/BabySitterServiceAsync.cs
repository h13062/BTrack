using BabyTracker.Core.Contract.Service;
using BabyTracker.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Infrastructure.Service
{
    public class BabySitterServiceAsync : IBabySitterServiceAsync
    {
        public Task<int> AddBabyAsync(BabySitterModel baby)
        {
            throw new NotImplementedException();
        }

        public Task<int?> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BabySitterModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BabySitterModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BabySitterModel> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateBabyAsync(BabySitterModel baby)
        {
            throw new NotImplementedException();
        }
    }
}
