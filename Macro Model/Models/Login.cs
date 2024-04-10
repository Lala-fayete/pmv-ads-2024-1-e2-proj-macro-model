using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Macro_Model.Models
{
    [Table("Login")]
    public class Login
    {
		[Key]
		[Display(Name = "Digite seu e-mail para login")]
		public string Email { get; set; }

        [Display(Name = "Digite sua senha")]
		public string Senha { get; set; }

	}
}
