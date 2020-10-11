using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public interface IInitiativeRepository 
	{
		Task<List<Initiative>> GetAllInitiatives();

		List<Initiative> GetInitiativeByYear(int year);

		Task<Initiative> GetInitiativeById(long Id);

		Task<bool> CreateInitiative(Initiative initiative);
		Task<bool> DeleteInitiative(long id);
		Task<bool> UpdateInitiative(Initiative initiative);
	}
}
