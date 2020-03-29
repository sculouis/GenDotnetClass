using System.Linq;
using DataAccess.Interfaces;

namespace DataAccess
{
    public class EXPMasterRepository : GenericRepository<EXPMaster>, IEXPMasterRepository
    {
        public EXPMasterRepository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<EXPMaster> IEXPMasterRepository.GetFormMasterAll() =>
            GetAll().OrderByDescending(e => e.Id);
    }
}