using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class RateRepository : IRateRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public RateRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}
		public async Task<bool> CreateRate(Rate rate)
		{
			await InitiativeContext.Rates.AddAsync(rate);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeletRate(int id)
		{
			Rate record = await InitiativeContext.Rates.FirstOrDefaultAsync(j => j.RateId == id);
			InitiativeContext.Rates.Remove(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<Rate> GetRateById(int Id)
		{
			return await InitiativeContext.Rates.FirstOrDefaultAsync(i => i.RateId == Id);
		}

		public Task<List<Rate>> GetRateByUserId(long Id)
		{
			//return await InitiativeContext.Rates.FirstOrDefaultAsync(i => i.User == Id).ToAsyncList();
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateRate(Rate rate)
		{
			var record = await GetRateById(rate.RateId);
			record.Value = rate.Value;
			record.RateBy = rate.RateBy;
			record.User = rate.User;
			InitiativeContext.Rates.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}
	}
}
