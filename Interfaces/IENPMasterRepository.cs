using System.Linq;

namespace DataAccess.Interfaces
{
    public interface IENPMasterRepository:IGenericRepository<ENPMaster>
    {
        IQueryable<ENPMaster> GetENPMasterAll();
    }
}
