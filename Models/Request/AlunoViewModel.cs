using Aluno.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace Aluno.Models.Request
{
    public class AlunoViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatorio!! ")]
        public string Nome { get; set; }

        [RaValidation]
        public string RA { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public bool Ativo { get; set; }

    }
}
