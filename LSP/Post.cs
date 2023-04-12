namespace SOLIDPrinciples.LSP
{

    public class Post : IPOST
    {
        public virtual string CreatePost(PostDB db, string post)
        {
           return db.AddPost(post);
        }
    }

    public class PostTag : Post
    {
        public override string CreatePost(PostDB db, string post)
        {
              return db.AddPostTag(post);
        }
    }

    public class PostMention : Post
    {
        public override  string CreatePost(PostDB db, string post)
        {
           return db.AddPostMention(post);
        }
    }

}