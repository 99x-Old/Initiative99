using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class UserInitiativeActionRepository : IUserInitiativeActionRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public UserInitiativeActionRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}
		public async Task<bool> CreateUserAction(UserInitiativeAction record)
		{
			await InitiativeContext.UserInitiativeActions.AddAsync(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeleteUserAction(long ActionId, long UserId )
		{

			UserInitiativeAction record = new UserInitiativeAction
			{
				UserId = UserId,
				InitiativeActionId = ActionId
			};
			InitiativeContext.UserInitiativeActions.Remove(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async  Task<List<UserInitiativeAction>> GetActionsByUserId(long Id)
		{
			return await InitiativeContext.UserInitiativeActions.Where(x=>x.UserId == Id).ToListAsync();
		}

		public async Task<List<UserInitiativeAction>> GetUsersByAction(long Id)
		{
			return await InitiativeContext.UserInitiativeActions.Where(x => x.InitiativeActionId == Id).ToListAsync();
		}
	}
}
