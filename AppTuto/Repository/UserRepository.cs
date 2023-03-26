using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AppTuto.Entity;
using SQLite;


namespace AppTuto.Repository
{
    public class UserRepository
    {
        SQLiteAsyncConnection connection;
        public string StatusMessages { get; set; }
        public UserRepository(string dbPath) {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<User>();

        }
        public async Task AddNewUserAsync(string name)
        {
            int result = 0;
            try
            {
                result = await connection.InsertAsync(new User { Name = name });
                StatusMessages = $"{result} utilisateur ajouté :{name}";
            }
            catch (Exception ex)
            {

                StatusMessages = $"Impossible d'ajouter l'utilisateur : {name} .\n Erreur :{ex.Message}";
            }
        }
        public async Task<List<User>> GetUsersAsync() {
            try
            {
                return await connection.Table<User>().ToListAsync();
            }
            catch (Exception ex)
            {
                
                StatusMessages = $"Impossible de retourner la liste des l'utilisateurs .\n Erreur {ex.Message}";
            }
            return new List<User>();    
         }
    }
}
