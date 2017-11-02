
using Repository.Contracts.Core;

namespace Repository.Contracts.Dto
{
    public class Group : IEntity, IId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}