namespace Test.Services;

public interface IService
{
    void Add();

    List<Guid> GetAll();
}

public class Service : IService
{
    private static readonly List<Guid> _services = [];

    public Service()
    {
        if(true)
        {
        }

        Console.WriteLine();
    }

    public void Add()
    {
        _services.Add(Guid.NewGuid());
    }

    public List<Guid> GetAll()
    {
        return _services;
    }
}
