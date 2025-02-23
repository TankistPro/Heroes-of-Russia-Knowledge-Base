using KnowledgeBase.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KnowledgeBase.Sql
{
    public class NpgsqlRepository : IDisposable
    {
        private NpgsqlConnection _npgsqlConnection;

        public NpgsqlConnection connection
        {
            get { return _npgsqlConnection; }
        }

        public NpgsqlRepository()
        {
            _npgsqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=KnowledgeBase;");
        }

        public void Dispose()
        {
            _npgsqlConnection.Dispose();
        }
    }
}
