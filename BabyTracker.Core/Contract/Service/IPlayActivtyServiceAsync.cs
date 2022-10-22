using BabyTracker.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Core.Contract.Service
{
    public interface IPlayActivtyServiceAsync
    {
        Task<IEnumerable<PlayActivityModel>> GetAllAsync();
        Task<int> AddSleepAsync(PlayActivityModel sleep);
        Task<PlayActivityModel> GetByIdAsync(int id);
        Task<int> UpdateSleepAsync(PlayActivityModel sleep);
        Task<int?> DeleteByIdAsync(int id);
    }
}
