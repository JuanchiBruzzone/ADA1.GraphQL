using ADA1.GraphQL.Features.Person;

namespace ADA1.GraphQL.Features.GraphQL;

public class Query
{
    private readonly PersonService _personService;

    public Query(PersonService personService)
    {
        _personService = personService;
    }

    public List<Person.Person> GetPeople(int count)
    {
        return _personService.GetPeople(count);
    }
}