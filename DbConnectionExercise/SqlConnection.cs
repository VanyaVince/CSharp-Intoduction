using System;
using System.Threading;

namespace DbConnectionExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) 
            : base(connection)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SqlConnection is opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection is closed");
        }
    }
}