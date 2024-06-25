using ADA1.GraphQL.Features.Person;
using ADA1.GraphQL.Features.Tweet;

namespace ADA1.GraphQL.Features.GraphQL;

public class Query
{
    private readonly PersonService _personService;
    private readonly TweetService _tweetService;

    public Query(PersonService personService, TweetService tweetService)
    {
        _personService = personService;
        _tweetService = tweetService;
    }

    public List<Person.Person> GetPeople(int count)
    {
        return _personService.GetPeople(count);
    }

    public List<Tweet.Tweet> GetTweets(int count)
    {
        return _tweetService.GetTweets(count);
    }
}