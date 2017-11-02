namespace Repository.Contracts.Core
{
    public interface IId
    {
        int Id { get; set; }
    }
    public interface IEntity : IId
    {
        string Name { get; set; }
    }

    public interface IPerson : IId
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}