using ADA1.GraphQL.Features.GraphQL;
using ADA1.GraphQL.Features.Person;
using ADA1.GraphQL.Features.Tweet;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<PersonService>();
builder.Services.AddTransient<TweetService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<PersonType>()
    .AddType<TweetType>()
    .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);

var app = builder.Build();

app.MapGraphQL();

app.Run();