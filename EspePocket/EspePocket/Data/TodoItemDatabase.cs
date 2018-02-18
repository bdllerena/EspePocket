using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using EspePocket.Models;

namespace EspePocket.Data
{
    public class TodoItemDatabase
    {
        readonly SQLiteAsyncConnection database;
        /// <summary>
        /// Get string path from resources folder (Sqlite.db3) file }
        /// </summary>
        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TodoItem>().Wait();
        }
        /// <summary>
        /// Get current items from sqlite file
        /// </summary>
        public Task<List<TodoItem>> GetItemsAsync()
        {
            return database.Table<TodoItem>().ToListAsync();
        }
        /// <summary>
        /// Get current items from sqlite file that are already complete (marked with done)
        /// </summary>
        public Task<List<TodoItem>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }
        /// <summary>
        /// Get items from the database and placed by order in a list
        /// </summary>
        public Task<TodoItem> GetItemAsync(int id)
        {
            return database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        /// <summary>
        /// Save the current item, or updated it from the database file
        /// </summary>
        public Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        /// <summary>
        /// Delete the current item from the database file
        /// </summary>
        public Task<int> DeleteItemAsync(TodoItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
