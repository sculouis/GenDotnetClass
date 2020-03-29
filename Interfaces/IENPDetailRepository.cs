using System.Linq;

namespace DataAccess.Interfaces
{
    public interface IENPDetailRepository:IGenericRepository<ENPDetail>
    {
        IQueryable<ENPDetail> GetENPDetailAll();
    }
}
