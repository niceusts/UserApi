using System;

namespace UserApi.Models
{
	public class User
	{
		public int Cpf { get; set; }
		public string? Nome { get; set; }  //user type
		public DateTime DataNascimento { get; set; }
	}
}
