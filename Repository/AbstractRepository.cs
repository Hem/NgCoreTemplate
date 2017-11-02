using SimpleNet.Standard.Data.Repository;
using SimpleNet.Standard.Data;

namespace Repository
{
    public class BaseRepository : AbstractSimpleRepository
    {
        public override ISimpleDataAccessLayer Database { get; set; }

        public BaseRepository(ISimpleDataAccessLayer database) 
        {
            Database = database;               
        }
                        
    }
}
