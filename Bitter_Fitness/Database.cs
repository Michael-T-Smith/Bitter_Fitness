using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bitter_Fitness
{
    public class Database
    {
        /* Creates a connection with the database on dbPath */
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();
        }

        /* Creates a table for Person(user) */
        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
    }
}

