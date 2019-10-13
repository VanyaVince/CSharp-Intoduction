using System;

namespace DbConnectionExercise
{
    public abstract class DbConnection
    {
        public String Connection { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connection)
        {

            if (String.IsNullOrEmpty(connection))
                throw new ArgumentNullException(nameof(connection));
            
            this.Connection = connection;
        }

        public  abstract void OpenConnection();

        public abstract void CloseConnection();

        public void CheckTimeConnection()
        {
            var elapsedTime = new Random().Next(1,5);
            Console.WriteLine($"Random number is {elapsedTime}");
            Timeout = TimeSpan.FromSeconds(elapsedTime);

            if (Timeout.Seconds > 3)
                throw new TimeoutException();
        }
    }
}