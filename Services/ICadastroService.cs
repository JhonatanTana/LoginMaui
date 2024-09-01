using LoginMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaui.Services; 
public interface ICadastroService {

    Task<List<CadastroModel>> GetAllCadastros();
    Task<CadastroModel> GetCadastroById(int registroId);
    Task<int> AddCadastro(CadastroModel cadastro);
    Task<int> UpdateCadastro(CadastroModel cadastro);
    Task<int> DeleteCadastro(CadastroModel cadastro);
}
