using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class UserRepository : IUserRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public UserRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}
		public async Task<bool> CreateUser(User user)
		{
			await InitiativeContext.Users.AddAsync(user);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeleteUser(long id)
		{
			var record = await GetUserById(id);
			record.Status = false;
			InitiativeContext.Users.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<User> GetUserById(long Id)
		{
			return await InitiativeContext.Users.FirstOrDefaultAsync(i => i.Id == Id);
		}

		public async Task<bool> UpdateUser(User user)
		{
			var record = await GetUserById(user.Id);
			record.EmployeeNumber = user.EmployeeNumber;
			record.FirstName = user.FirstName;
			record.LastName = user.LastName;
			record.Address = user.Address;
			record.Email = user.Email;
			record.ContactNumber = user.ContactNumber;
			record.Department = user.Department;
			record.Project = user.Project;
			record.Password = user.Password;
			record.Status = user.Status;

			InitiativeContext.Users.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}
	}
}
