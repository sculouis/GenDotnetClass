using System.Linq;

namespace DataAccess.Interfaces
{
    public interface IEXPMasterRepository:IGenericRepository<EXPMaster>
    {
        IQueryable<EXPMaster> GetEXPMasterAll();
    }
}
