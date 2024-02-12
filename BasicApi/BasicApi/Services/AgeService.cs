namespace BasicApi.Services;

public class AgeService : IAgeService
{
    public bool IsAdult(int age)
    {
        return age >= 18;
    }
}