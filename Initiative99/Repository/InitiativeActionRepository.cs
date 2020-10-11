using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class InitiativeActionRepository : IInitiativeActionRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public InitiativeActionRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}
		public async Task<bool> CreateInitiativeAction(InitiativeAction initiativeAction)
		{
			await InitiativeContext.InitiativeActions.AddAsync(initiativeAction);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeleteInitiativeAction(long id)
		{
			var record = await GetInitiativeActionById(id);
			record.Status = false;
			InitiativeContext.InitiativeActions.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<List<InitiativeAction>> GetAllInitiativeAction()
		{
			return await InitiativeContext.InitiativeActions.Where(i => i.Status == true).ToListAsync();
		}

		public async Task<InitiativeAction> GetInitiativeActionById(long id)
		{
			return await InitiativeContext.InitiativeActions.FirstOrDefaultAsync(x => x.InitiativeActionId == id);
		}

		public async Task<List<InitiativeAction>> GetInitiativeActionByInitiativeId(long Id)
		{
			return await InitiativeContext.InitiativeActions.Where(j => j.InitiativeId == Id).ToListAsync();
		}

		public async Task<bool> UpdateInitiativeAction(InitiativeAction initiativeAction)
		{
			var record = await GetInitiativeActionById(initiativeAction.InitiativeActionId);
			record.Progress = initiativeAction.Progress;
			record.Name = initiativeAction.Name;
			record.Description = initiativeAction.Description;
			record.InitiativeId = initiativeAction.InitiativeId;
			record.Deadline = initiativeAction.Deadline;
			record.CreatedBy = initiativeAction.CreatedBy;
			record.CreatedDate = initiativeAction.CreatedDate;
			record.UpdatedDate = initiativeAction.UpdatedDate;
			InitiativeContext.InitiativeActions.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

	}
}
