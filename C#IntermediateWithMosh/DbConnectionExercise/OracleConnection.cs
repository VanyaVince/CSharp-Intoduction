using System;

namespace DbConnectionExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("OracleConnection is opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("OracleConnection is closed");
        }
    }
}