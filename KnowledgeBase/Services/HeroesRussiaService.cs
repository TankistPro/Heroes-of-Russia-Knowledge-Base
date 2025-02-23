﻿using KnowledgeBase.Models;
using KnowledgeBase.Sql;
using Npgsql;
using System.Collections.Generic;

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
                        firstName: reader.GetString(1),
                        lastName: reader.GetString(2),
                        middleName: reader.GetString(3),
                        biography: reader.GetString(4),
                        placeBirth: reader.GetString(5),
                        imageUrl: reader.GetString(6),
                        birthDate: reader.IsDBNull(7) ? null : reader.GetDateTime(7)
                    ));
                }
            }

            return result;
        }
    }
}
