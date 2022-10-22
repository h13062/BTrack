using BabyTracker.Core.Contract.Service;
using BabyTracker.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Infrastructure.Service
{
    public class SleepActivityServiceAsync : ISleepActivityServiceAsync
    {
        public Task<int> AddSleepAsync(SleepActivityModel sleep)
        {
            throw new NotImplementedException();
        }

        public Task<int?> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SleepActivityModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SleepActivityModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateSleepAsync(SleepActivityModel sleep)
        {
            throw new NotImplementedException();
        }
    }
}
