using GitForFun;

public class Program
{
    static void Main()
    {
        //Comment
        // Jidapa: this is my code
        // other 2 + 1
    }

}

public class JokeTime
{
    private string JokeStart{get; set;}
    private  string Response{get; set;}

    public int Funniness {get; set;}

    public JokeTime(string JokeStart, string Response, int Funniness)
    {
        this.JokeStart=JokeStart;
        this.Response=Response;
        this.Funniness=Funniness;
    }
}