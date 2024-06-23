using Bogus;

namespace ADA1.GraphQL.Features.Person;

public class PersonService
{
    private readonly Faker<Person> _faker;

    public PersonService()
    {
        var random = new Random();

        _faker = new Faker<Person>()
            .RuleFor(p => p.Id, f => random.Next(1, 1_000_000))
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