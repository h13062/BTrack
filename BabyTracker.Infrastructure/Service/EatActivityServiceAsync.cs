using BabyTracker.Core.Contract.Repository;
using BabyTracker.Core.Contract.Service;
using BabyTracker.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Infrastructure.Service
{
    
    public class EatActivityServiceAsync : IEatActivyServiceAsync
    {
        private readonly IEatActivityRepositoryAsync eatActivyRepositoryAsync;
        public Task<int> AddEatAsync(EatActivityModel eat)
        {
            throw new NotImplementedException();
        }

        public Task<int?> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EatActivityModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EatActivityModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEatAsync(EatActivityModel eat)
        {
            throw new NotImplementedException();
        }
    }
}
