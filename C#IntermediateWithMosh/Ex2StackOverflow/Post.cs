using System;

namespace Ex2StackOverflow
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Vote { get; private set; }

        public Post(string title, DateTime time)
        {
            this.Title = title;
            this.Date = time;
        }

        public Post(string title, string description, DateTime time)
            : this(title, time)
        {
            this.Description = description;
        }

        public void UpVote()
        {
            this.Vote += 1;
        }

        public void DownVote()
        {
            this.Vote -= 1;
        }

        public String Print()
        {
            return $"Title: {this.Title}\nDescription: {this.Description}\n" +
                   $"Date and Time: {this.Date}\nPeople who like this post: {this.Vote}";
        }
    }
}