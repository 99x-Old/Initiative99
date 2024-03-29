﻿using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public  interface IUserInitiativeActionRepository
	{
		Task<List<UserInitiativeAction>> GetUsersByAction(long Id);
		Task<List<UserInitiativeAction>> GetActionsByUserId(long Id);
		Task<bool> CreateUserAction(UserInitiativeAction record);
		Task<bool> DeleteUserAction(long ActionId, long userid);
		
	}
}
