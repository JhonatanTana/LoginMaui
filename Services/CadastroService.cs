using LoginMaui.Models;
using SQLite;
using System.Data.Entity;

namespace LoginMaui.Services;
public class CadastroService : ICadastroService {

    private SQLiteAsyncConnection _dbConnection;
    public CadastroService() {

        SetUpDb();
    }
    private async void SetUpDb() {

        if (_dbConnection == null) {

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Login.db3");

            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<CadastroModel>();
        }
    }
    public async Task<int> AddCadastro(CadastroModel cadastro) {

        return await _dbConnection.InsertAsync(cadastro);
    }

    public async Task<int> DeleteCadastro(CadastroModel cadastro) {

        return await _dbConnection.DeleteAsync(cadastro);
    }

    public async Task<List<CadastroModel>> GetAllCadastros() {

        return await _dbConnection.Table<CadastroModel>().ToListAsync();
    }

    public async Task<CadastroModel> GetCadastroById(int id) {

        return await _dbConnection.Table<CadastroModel>().FirstOrDefaultAsync(c => c.CadastroId == id);
    }

    public async Task<int> UpdateCadastro(CadastroModel cadastro) {

        return await _dbConnection.UpdateAsync(cadastro);
    }
}