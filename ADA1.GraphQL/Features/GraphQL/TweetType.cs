namespace ADA1.GraphQL.Features.GraphQL;

public class TweetType : ObjectType<Tweet.Tweet>
{
    protected override void Configure(IObjectTypeDescriptor<Tweet.Tweet> descriptor)
    {
        descriptor.Field(x => x.Id).Type<NonNullType<IntType>>();
        descriptor.Field(x => x.Content).Type<NonNullType<StringType>>();
        descriptor.Field(x => x.CreatedAt).Type<NonNullType<DateType>>();
        descriptor.Field(x => x.Author).Type<NonNullType<PersonType>>();
        descriptor.Field(x => x.Likes).Type<NonNullType<IntType>>();
        descriptor.Field(x => x.Comments).Type<NonNullType<IntType>>();
    }
}