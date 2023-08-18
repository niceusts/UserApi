using System.Collections.Generic;
using System.Linq;
using UserApi.Models;

namespace UserApi.Services
{
	public class UserService
	{
		private readonly List<User> _users = new List<User>();

		public void AddUser(User user)
		{
			_users.Add(user);
		}

		public User GetUserByCpf(int cpf)
		{
			return _users.FirstOrDefault(u => u.Cpf == cpf);
		}
	}
}
