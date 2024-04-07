namespace SearchingTours.Infrastructure.Persistence.Utils;

public class Generator
{
    private static readonly Random Random = new Random();

    public static int GenerateRandomId()
    {
        return Random.Next(0, 1000000000);
    }
}