﻿using BabyTracker.Core.Contract.Service;
using BabyTracker.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Infrastructure.Service
{
    public class PlayActivityServiceAsync : IPlayActivtyServiceAsync
    {
        public Task<int> AddPlayAsync(PlayActivityModel sleep)
        {
            throw new NotImplementedException();
        }

        public Task<int?> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayActivityModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PlayActivityModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePlayAsync(PlayActivityModel sleep)
        {
            throw new NotImplementedException();
        }
    }
}