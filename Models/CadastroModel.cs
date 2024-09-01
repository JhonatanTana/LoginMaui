using SQLite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaxLengthAttribute = SQLite.MaxLengthAttribute;
using TableAttribute = SQLite.TableAttribute;

namespace LoginMaui.Models;

[Table("Cadastro")]
public class CadastroModel {

    [PrimaryKey, AutoIncrement]
    public int CadastroId { get; set; }

    [NotNull, MaxLength(20)]
    [Required(ErrorMessage = "O campo Nome é obrigatorio")]
    public string Nome { get; set; }

    [NotNull, MaxLength(50)]
    [Required(ErrorMessage = "O campo Sobrenome é obrigatorio")]
    public string Sobrenome { get; set; }

    [NotNull]
    public DateTime DataNascimento { get; set; }

    [NotNull, MaxLength(100)]
    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O Email informado não é válido.")]
    public string CadastroEmail { get; set; }

    [NotNull, MaxLength(15)]
    public string Telefone { get; set; }

    [NotNull, MaxLength(1)]
    public string Genero { get; set; }

    [NotNull, MaxLength(9)]
    public string Cep { get; set; }

    [NotNull, MaxLength(50)]
    public string Rua { get; set; }

    [NotNull, MaxLength(5)]
    public string Numero { get; set; }

    [NotNull, MaxLength(15)]
    public string Complemento { get; set; }

    [NotNull, MaxLength(15)]
    public string Bairro { get; set; }

    [NotNull, MaxLength(15)]
    public string Cidade { get; set; }

    [NotNull, MaxLength(2)]
    public string Estado { get; set; }

    public int UsuarioId { get; set; }

    [Ignore]
    public UsuarioModel Usuario { get; set; }
}