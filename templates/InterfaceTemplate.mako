using System.Linq;

namespace DataAccess.Interfaces
{
    public interface I${TableName}Repository:IGenericRepository<${TableName}>
    {
        IQueryable<${TableName}> Get${TableName}All();
    }
}
