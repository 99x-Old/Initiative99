using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class InitiativeRepository :  IInitiativeRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public InitiativeRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}

		public async Task< List<Initiative>> GetAllInitiatives()
		{
			return await InitiativeContext.Initiatives.Where(i => i.Status == true).ToListAsync();
		}

		public List<Initiative> GetInitiativeByYear(int year)
		{
			throw new NotImplementedException();
		}

		public async Task<Initiative> GetInitiativeById(long Id)
		{
			return await InitiativeContext.Initiatives.FirstOrDefaultAsync(i => i.Initiativid == Id);

		}

		public async Task<bool> CreateInitiative(Initiative initiative)
		{
			await InitiativeContext.Initiatives.AddAsync(initiative);
			return await InitiativeContext.SaveChangesAsync() > 0;
			
		}
		public async Task<bool> DeleteInitiative(long Id)
		{
			var record = await GetInitiativeById(Id);
			record.Status = false;
			InitiativeContext.Initiatives.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;

		}

		public async Task<bool> UpdateInitiative(Initiative initiative)
		{
			var record = await GetInitiativeById(initiative.Initiativid);
			record.Name = initiative.Name;
			record.InitiativeYear = initiative.InitiativeYear;
			record.Description = initiative.Description;
			InitiativeContext.Initiatives.Update(initiative);
			return await InitiativeContext.SaveChangesAsync() > 0;

		}

	}
}
