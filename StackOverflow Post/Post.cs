using System;
using System.Runtime.InteropServices;

namespace StackOverflow_Post
{
    class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime CreatedAt { get; set; }
        private int _likes = 0;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreatedAt = DateTime.Now;
        }

        public void Like()
        {
            _likes++;
        }

        public void Dislike()
        {
            _likes--;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {this.Title} Description: {this.Description} Likes: {this._likes}");
        }
    }
}