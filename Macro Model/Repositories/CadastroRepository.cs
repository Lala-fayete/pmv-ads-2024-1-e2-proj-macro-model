using Macro_Model.Interfaces;
using Macro_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Macro_Model.Repositories
{
	public class CadastroRepository : ICadastroRepository
	{
		private AppDbContext _CadastroContext;

		public CadastroRepository(AppDbContext cadastroContext)
		{
			_CadastroContext = cadastroContext;
		}



		public async Task<Cadastro> GetByIDAsync(int? i)
		{
					
			return await _CadastroContext.Cadastro.FindAsync(i);
		}

		public async Task<IEnumerable<Cadastro>> GetCadastrosAsync()
		{
			try
			{
				return await _CadastroContext.Cadastro.ToListAsync();
			}
			catch (Exception)
			{

				throw;
			}
		}

		
		public async Task<Cadastro> RemoveAsync(Cadastro cadastro)
		{
			_CadastroContext.Remove(cadastro);
			await _CadastroContext.SaveChangesAsync();
			return cadastro;
		}

		
		public async Task<Cadastro> AddAsync(Cadastro cadastro)
		{

			_CadastroContext.Add(cadastro);
			await _CadastroContext.SaveChangesAsync();
			return cadastro;

		}

		public async Task<Cadastro> UpdateAsync(Cadastro cadastro)
		{

			_CadastroContext.Update(cadastro);
			await _CadastroContext.SaveChangesAsync();
			return cadastro;
		}
	}
}
