using System;

namespace DbConnectionExercise
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        public String Query { get; set; }

        public DbCommand(DbConnection dbConnection, string query)
        {
            if (dbConnection.Equals(null) || String.IsNullOrEmpty(query))
                throw new ArgumentNullException();

            this._dbConnection = dbConnection;
            this.Query = query;
        }

        public void Execute()
        {
            this._dbConnection.CheckTimeConnection();
            this._dbConnection.OpenConnection();
            Console.WriteLine(this.Query);
            this._dbConnection.CloseConnection();
        }
    }
}