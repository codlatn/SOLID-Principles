namespace SOLIDPrinciples
{
    public class Program
    {
        static void Main(String[] args)
        {
            //Liskov Substitution Principle (LSP)
            LSP.LspTest LSP = new LSP.LspTest();
            string post = LSP.SwitchObj("#post");
            Console.WriteLine("LSP -> SwitchObj Method: \n" + post);

            string[] postData = {"#Tag","@Mention","Hello" };
            string postList = LSP.FromArray(postData);
            Console.WriteLine("LSP -> FromArray Method : \n" + postList);
               
        }
    }
}