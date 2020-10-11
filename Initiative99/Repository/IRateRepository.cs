using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public interface IRateRepository
	{
		Task<Rate> GetRateById(int Id);
		Task<List<Rate>> GetRateByUserId(long Id);
		Task<bool> CreateRate(Rate rate);
		Task<bool> DeletRate(int id);
		Task<bool> UpdateRate(Rate rate);

	}
}
