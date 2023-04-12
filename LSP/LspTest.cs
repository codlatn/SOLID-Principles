namespace SOLIDPrinciples.LSP
{

    public class LspTest
    {
        public string Res { get; set; } = default!;

        //postData, It could be an Array...
        public string SwitchObj(string postData)
        {

            Res = "";
            PostDB db = new PostDB();
            //LSP
            Post postObj;

            if (postData.StartsWith('#')) postObj = new PostTag();

            else if (postData.StartsWith('@')) postObj = new PostMention();

            else postObj = new Post();
                        //LSP
            return Res = postObj.CreatePost(db, postData);

        }

        public string FromArray(string[] postData)
        {

            Res = "";
            PostDB db = new PostDB();

            //LSP
            Post postObj;

            foreach (var post in postData)
            {
                if (post.StartsWith('#')) postObj = new PostTag();

                else if (post.StartsWith('@')) postObj = new PostMention();

                else postObj = new Post();
                //LSP
                Res += postObj.CreatePost(db, post);

            }

            return Res;

        }
    }

}



