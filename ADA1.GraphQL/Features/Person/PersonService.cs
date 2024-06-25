using ADA1.GraphQL.Features.Rng;
using Bogus;

namespace ADA1.GraphQL.Features.Person;

public class PersonService
{
    private readonly Faker<Person> _faker;
    private readonly RngService _rngService;

    public PersonService(RngService rngService)
    {
        _rngService = rngService;
        
        _faker = new Faker<Person>()
            .RuleFor(p => p.Id, f => _rngService.GetRandomInt(0, 1_000_000))
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.Phone, f => f.Phone.PhoneNumber());
    }

    public List<Person> GetPeople(int count)
    {
        return _faker.Generate(count).ToList();
    }
}