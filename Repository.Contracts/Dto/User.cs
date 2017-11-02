
using Repository.Contracts.Core;

namespace Repository.Contracts.Dto
{
    public class User : IPerson, IId
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}