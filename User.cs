/// <summary>
/// Classe que representa um usuário.
/// </summary>using System;

namespace UserApi.Models
{
	public class User
	{
		/// <summary>
		/// CPF do usuário.
		/// </summary>
		public int Cpf { get; set; }
		/// <summary>
		/// Nome do usuário.
		/// </summary>
		public string? Nome { get; set; }  //user type
		/// <summary>
		/// Data de nascimento do usuário.
		/// </summary>
		public DateTime DataNascimento { get; set; }
	}
}
