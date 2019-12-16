using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post("Hello World", "This is a test");
            newPost.Like();
            newPost.Like();
            newPost.Dislike();
            newPost.Show();
        }
    }
}
