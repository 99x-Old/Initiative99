using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public interface IUserRepository
	{
		Task<User> GetUserById(long Id);
		Task<bool> CreateUser(User user);
		Task<bool> DeleteUser(long id);
		Task<bool> UpdateUser(User user);
	}
}
