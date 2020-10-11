using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public interface IInitiativeActionRepository
	{
		Task<List<InitiativeAction>> GetAllInitiativeAction();
		Task<InitiativeAction> GetInitiativeActionById(long id);
		Task<List<InitiativeAction>> GetInitiativeActionByInitiativeId(long Id);
		Task<bool> CreateInitiativeAction(InitiativeAction initiativeAction);
		Task<bool> DeleteInitiativeAction(long id);
		Task<bool> UpdateInitiativeAction(InitiativeAction initiativeAction);
	}
}
