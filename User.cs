/// <summary>
/// Classe que representa um usu�rio.
/// </summary>using System;

namespace UserApi.Models
{
	public class User
	{
		/// <summary>
		/// CPF do usu�rio.
		/// </summary>
		public int Cpf { get; set; }
		/// <summary>
		/// Nome do usu�rio.
		/// </summary>
		public string? Nome { get; set; }  //user type
		/// <summary>
		/// Data de nascimento do usu�rio.
		/// </summary>
		public DateTime DataNascimento { get; set; }
	}
}
