namespace ADA1.GraphQL.Features.GraphQL;

public class PersonType : ObjectType<Person.Person>
{
    protected override void Configure(IObjectTypeDescriptor<Person.Person> descriptor)
    {
        descriptor.Field(x => x.Id).Type<NonNullType<IntType>>();
        descriptor.Field(x => x.FirstName).Type<NonNullType<StringType>>();
        descriptor.Field(x => x.LastName).Type<NonNullType<StringType>>();
        descriptor.Field(x => x.Email).Type<NonNullType<StringType>>();
        descriptor.Field(x => x.Phone).Type<NonNullType<StringType>>();
    }
}