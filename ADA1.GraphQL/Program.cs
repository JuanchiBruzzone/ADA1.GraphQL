using ADA1.GraphQL.Features.GraphQL;
using ADA1.GraphQL.Features.Person;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<PersonService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<PersonType>();

var app = builder.Build();

app.MapGraphQL();

app.Run();