using Humanizer.Localisation.DateToOrdinalWords;
using Macro_Model.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace Macro_Model.Interfaces
{
	public interface ICadastroService
	{
		Task<IEnumerable<Cadastro>> GetCadastros();
		Task<Cadastro> GetByID(int? i);

		Task Add(Cadastro cadastro);

		Task Update(Cadastro cadastro);	

		Task Remove(int id);
	}
}
