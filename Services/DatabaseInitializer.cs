using LoginMaui.Models;
using SQLite;
using System.IO;
using System.Threading.Tasks;

namespace LoginMaui.Services {
    public class DatabaseInitializer {
        private SQLiteAsyncConnection _dbConnection;

        public DatabaseInitializer() {
            SetUpDb().Wait();
        }

        private async Task SetUpDb() {
            if (_dbConnection == null) {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Login.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);

                await _dbConnection.CreateTableAsync<UsuarioModel>();
                await _dbConnection.CreateTableAsync<CadastroModel>();
            }
        }

        public SQLiteAsyncConnection GetDbConnection() {
            return _dbConnection;
        }
    }
}