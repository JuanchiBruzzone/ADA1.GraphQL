namespace ADA1.GraphQL.Features.Rng;

public class RngService
{
    private readonly Random _random;
    
    public RngService()
    {
        _random = new Random();
    }
    
    public int GetRandomInt(int min, int max)
    {
        return _random.Next(min, max);
    }
}