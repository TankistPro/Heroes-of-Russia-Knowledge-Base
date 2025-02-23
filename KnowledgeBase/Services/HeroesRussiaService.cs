using KnowledgeBase.Models;
using KnowledgeBase.Sql;
using Npgsql;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;

namespace KnowledgeBase.Services
{
    public class HeroesRussiaService
    {

        public async Task<List<HeroesRussiaVM>> GetAll()
        {
            var result = new List<HeroesRussiaVM>();

            using (var npgsqlConnection = new NpgsqlRepository().connection)
            {
                await npgsqlConnection.OpenAsync();
                var command = new NpgsqlCommand();
                command.Connection = npgsqlConnection;

                command.CommandText = $"SELECT * FROM heroesrussia;";

                NpgsqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    result.Add(new HeroesRussiaVM(
                        id: (int)reader["id"],
                        title: reader.GetString(1),
                        description: reader.GetString(2),
                        imageUrl: reader.GetString(3)
                    ));
                }
            }

            return result;
        }
    }
}
