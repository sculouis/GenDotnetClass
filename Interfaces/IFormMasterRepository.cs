using System.Linq;

namespace DataAccess.Interfaces
{
    public interface IFormMasterRepository:IGenericRepository<FormMaster>
    {
        IQueryable<FormMaster> GetFormMasterAll();
    }
}
