using ADA1.GraphQL.Features.Person;
using Bogus;

namespace ADA1.GraphQL.Features.Tweet;

public class TweetService
{
    private readonly Faker<Tweet> _faker;
    private readonly PersonService _personService;

    public TweetService(PersonService personService)
    {
        _personService = personService;
        
        var random = new Random();

        _faker = new Faker<Tweet>()
            .RuleFor(p => p.Id, random.Next(1, 1_000_000))
            .RuleFor(p => p.Content, f => f.Lorem.Text())
            .RuleFor(p => p.CreatedAt, f => f.Date.Past())
            .RuleFor(p => p.Author, _personService.GetPeople(1).Single())
            .RuleFor(p => p.Likes, random.Next(1, 1_000_000))
            .RuleFor(p => p.Comments, random.Next(1, 1_000_000));
    }
    
    public List<Tweet> GetTweets(int count)
    {
        return _faker.Generate(count).ToList();
    }
}