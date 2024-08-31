using LoginMaui.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaui.Services {
    public class UsuarioService : IUsuarioService {

        private SQLiteAsyncConnection _dbConnection;
        public UsuarioService() {
            SetUpDb();
        }
        private async void SetUpDb() {

            if (_dbConnection == null) {

                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Login.db3");

                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<UsuarioModel>();
            }
        }

        public async Task<int> AddUsuario(UsuarioModel usuario) {
            
            return await _dbConnection.InsertAsync(usuario);
        }

        public async Task<int> DeleteUsuario(UsuarioModel usuario) {
            
            return await _dbConnection.DeleteAsync(usuario);
        }

        public async Task<List<UsuarioModel>> GetAllUsuarios() {

            return await _dbConnection.Table<UsuarioModel>().ToListAsync();
        }

        public async Task<int> UpdateUsuario(UsuarioModel usuario) {

            return await _dbConnection.UpdateAsync(usuario);
        }

        public Task<UsuarioModel> GetUsuarioById(int registroId) {
            throw new NotImplementedException();
        }
    }
}
