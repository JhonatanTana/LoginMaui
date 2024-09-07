using LoginMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaui.Services; 
public interface IUsuarioService {

    //Task InitializeAsync();
    Task<List<UsuarioModel>> GetAllUsuarios();
    Task<UsuarioModel> GetUsuarioById(int registroId);
    Task<int> AddUsuario(UsuarioModel usuario);
    Task<int> UpdateUsuario(UsuarioModel usuario);
    Task<int> DeleteUsuario(UsuarioModel usuario);
    Task<int> DeleteUsuarioById(int registroId);

}
