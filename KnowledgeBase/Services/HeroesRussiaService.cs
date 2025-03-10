﻿using KnowledgeBase.Models;
using KnowledgeBase.Sql;
using Npgsql;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KnowledgeBase.Services
{
    public class HeroesRussiaService
    {
        /// <summary>
        /// Получить всех героев
        /// </summary>
        /// <returns></returns>
        async public Task<List<HeroesRussiaVM>> GetAll()
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

        /// <summary>
        /// Поиск героя
        /// </summary>
        /// <param name="subString"></param>
        /// <returns></returns>
        async public Task<List<HeroesRussiaVM>> Search(string subString)
        {
            var result = new List<HeroesRussiaVM>();

            using (var npgsqlConnection = new NpgsqlRepository().connection)
            {
                await npgsqlConnection.OpenAsync();
                var command = new NpgsqlCommand();
                command.Connection = npgsqlConnection;

                command.CommandText = $"SELECT * FROM heroesrussia WHERE (lastname || ' ' || firstname || ' ' || middlename) ILIKE @FIO;";
                command.Parameters.AddWithValue("FIO", $"%{subString}%");

                NpgsqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
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
