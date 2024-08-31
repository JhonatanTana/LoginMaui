using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaui.Models {
    public class CadastroModel {


        [Required(ErrorMessage = "O campo Nome é obrigatorio")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo Sobrenome é obrigatorio")]
        public string Sobrenome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; } = DateTime.Today;
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O Email informado não é válido.")]
        public string CadastroEmail { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
