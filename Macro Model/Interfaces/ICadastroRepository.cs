using Macro_Model.Models;

namespace Macro_Model.Interfaces
{
	public interface ICadastroRepository
	{
		Task<IEnumerable<Cadastro>> GetCadastrosAsync();
		Task<Cadastro> GetByIDAsync(int? i);

		Task<Cadastro> AddAsync(Cadastro cadastro);

		Task<Cadastro> UpdateAsync(Cadastro cadastro);

		Task<Cadastro> RemoveAsync(Cadastro cadastro);
	}
}

