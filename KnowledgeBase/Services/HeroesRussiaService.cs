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

        public List<HeroesRussiaVM> GetAll()
        {
            var result = new List<HeroesRussiaVM>();

            using (var npgsqlConnection = new NpgsqlRepository().connection)
            {
                npgsqlConnection.Open();
                var command = new NpgsqlCommand();
                command.Connection = npgsqlConnection;

                command.CommandText = $"SELECT * FROM heroesrussia;";

                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
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
