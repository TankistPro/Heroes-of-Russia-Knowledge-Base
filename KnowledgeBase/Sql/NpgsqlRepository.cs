using Npgsql;
using System;

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
