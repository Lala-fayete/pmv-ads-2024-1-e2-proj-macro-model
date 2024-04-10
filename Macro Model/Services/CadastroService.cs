using AutoMapper;
using Macro_Model.Interfaces;
using Macro_Model.Models;

namespace Macro_Model.Services
{
	public class CadastroService : ICadastroService
	{
		private ICadastroRepository _CadastroRepository;
		private readonly IMapper mapper;

		public CadastroService(IMapper mapper, ICadastroRepository cadastroRepository)
		{
			this.mapper = mapper;
			this._CadastroRepository = cadastroRepository;
		}

		public async Task Add(Cadastro cadastro)
		{
			var add = await _CadastroRepository.AddAsync(cadastro);
		}

		public async Task<Cadastro> GetByID(int? i)
		{
			var add = await _CadastroRepository.GetByIDAsync(i);
			return add;
		}

		public async Task<IEnumerable<Cadastro>> GetCadastros()
		{
			var add = await _CadastroRepository.GetCadastrosAsync();
			return add;
		}

		public async Task Remove(int i)
		{
			var cadastro = await _CadastroRepository.GetByIDAsync(i);
			await _CadastroRepository.RemoveAsync(cadastro);

		}

		public async Task Update(Cadastro cadastro)
		{
			
			await _CadastroRepository.UpdateAsync(cadastro);

		}
	}
}
