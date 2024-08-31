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

        [Required]
        public string Senha { get; set; }

        [Required]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmacaoSenha { get; set; }
    }
}
