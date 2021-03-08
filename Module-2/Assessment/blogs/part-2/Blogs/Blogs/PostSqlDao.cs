using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogs
{
    public class PostSqlDao : IPostDao
    {
        private readonly string connectionString;

        public PostSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Post> GetAllPosts()
        {
            IList<Post> posts = new List<Post>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); //Open

                SqlCommand command = new SqlCommand("Select * from blog_posts", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Post post = new Post();

                    post.Name = Convert.ToString(reader["name"]);
                    post.Body = Convert.ToString(reader["body"]);
                    post.IsPublished = Convert.ToBoolean(reader["published"]);
                    post.Created = Convert.ToDateTime(reader["created"]);

                    posts.Add(post);
                }
            }
            return posts;
        }

        public void Save(Post newPost)
        {
            // Implement this method to save post to database
        }
    }
}