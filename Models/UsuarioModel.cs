using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxLengthAttribute = SQLite.MaxLengthAttribute;
using TableAttribute = SQLite.TableAttribute;

namespace LoginMaui.Models;

[Table("Usuario")]
public class UsuarioModel {

    [PrimaryKey, AutoIncrement]
    public int RegistroId { get; set; }

    [NotNull, MaxLength(30)]
    public string Usuario { get; set; }

    [NotNull, MaxLength(30)]
    [Required(ErrorMessage = "A senha é obrigatoria")]
    public string Senha { get; set; }
}
