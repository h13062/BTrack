using BabyTracker.Core.Contract.Service;
using BabyTracker.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Infrastructure.Service
{
    public class ParentServiceAsync : IParentServiceAsync
    {
        public Task<int> AddParentAsync(ParentModel parent)
        {
            throw new NotImplementedException();
        }

        public Task<int?> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParentModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ParentModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ParentModel> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateParentAsync(ParentModel parent)
        {
            throw new NotImplementedException();
        }
    }
}
