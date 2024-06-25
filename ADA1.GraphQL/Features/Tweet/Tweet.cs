namespace ADA1.GraphQL.Features.Tweet;

public class Tweet
{
    public int Id { get; set; }
    
    public string? Content { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public Person.Person? Author { get; set; }
    
    //JUST NUMBERS TO SIMULATE MODEL, NO COMPLEXITY NEEDED
    public int Likes { get; set; }
    public int Comments { get; set; }
}