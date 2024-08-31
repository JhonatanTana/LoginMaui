using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaui.Components.Models {
    public class RegistroModel {

        [Key]
        public int RegistroId { get; set; }

        [Required(ErrorMessage = "O usuário é obrigatório.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Por favor, digite a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Por favor, confirme a senha")]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmacaoSenha { get; set; }
    }
}
