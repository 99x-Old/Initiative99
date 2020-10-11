using Initiative99.Models;
using Initiative99.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.DataManager
{
	public class InitiativeManager : IDataRepository<Initiative>
	{
		readonly InitiativeContext _initiativeContext;
		public InitiativeManager(InitiativeContext context)
		{
			_initiativeContext = context;
		}
		public IEnumerable<Initiative> GetAll()
		{
			return _initiativeContext.Initiatives.ToList();
		}
		public Initiative Get(long id)
		{
			return _initiativeContext.Initiatives.FirstOrDefault(i => i.Initiativid == id);
		}
		public void Add(Initiative entity)
		{
			_initiativeContext.Initiatives.Add(entity);
			_initiativeContext.SaveChanges();
		}
		public void Update(Initiative initiative, Initiative entity)
		{
			initiative.Initiativid = entity.Initiativid;
			initiative.InitiativeYear = entity.InitiativeYear;
			initiative.Name = entity.Name;
			initiative.Status = entity.Status;
			initiative.CreatedDate = entity.CreatedDate;
			initiative.Description = entity.Description;

			_initiativeContext.SaveChanges();
		}

		public void Delete(Initiative entity)
		{
			_initiativeContext.Initiatives.Remove(entity);
			_initiativeContext.SaveChanges();
		}

		

		

		
	}
}
