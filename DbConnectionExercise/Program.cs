using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand dbCommand = new DbCommand(new SqlConnection("https://codewithmosh.com/courses/224763/lectures/3497989"), "SELECT FROM FAMILY ALL MOTHERS WHERE NAME IS 'ALA'");
            dbCommand.Execute();
        }
    }
}
