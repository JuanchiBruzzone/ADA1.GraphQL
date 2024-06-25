using ADA1.GraphQL.Features.Person;
using ADA1.GraphQL.Features.Rng;
using Bogus;

namespace ADA1.GraphQL.Features.Tweet;

public class TweetService
{
    private readonly Faker<Tweet> _faker;
    private readonly PersonService _personService;
    private readonly RngService _rngService;

    public TweetService(PersonService personService, RngService rngService)
    {
        _personService = personService;
        _rngService = rngService;

        _faker = new Faker<Tweet>()
            .RuleFor(p => p.Id, f => _rngService.GetRandomInt(0, 1_000_000))
            .RuleFor(p => p.Content, f => f.Lorem.Text())
            .RuleFor(p => p.CreatedAt, f => f.Date.Past())
            .RuleFor(p => p.Author, _personService.GetPeople(1).Single())
            .RuleFor(p => p.Likes, f => _rngService.GetRandomInt(0, 1_000_000))
            .RuleFor(p => p.Comments, f => _rngService.GetRandomInt(0, 1_000_000));
    }
    
    public List<Tweet> GetTweets(int count)
    {
        return _faker.Generate(count).ToList();
    }
}