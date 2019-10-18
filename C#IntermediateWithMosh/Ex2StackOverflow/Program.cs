using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Newlyweds", "Wedding of Maria and Sergio", DateTime.Now);
            Console.WriteLine($"Post - {post.Title.ToUpper()}, enter like or dislike several times or type exit to terminate program");

            while (true)
            {
                var userDecision = UserService.GetUserDecision(Console.ReadLine());

                if (userDecision != null && userDecision.ToLower() == "exit")
                    break;
                if (userDecision == "like")
                    post.UpVote();
                else
                    post.DownVote();
            }

            Console.WriteLine(post.Print());
        }
    }
}
