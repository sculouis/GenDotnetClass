using System.Linq;
using DataAccess.Interfaces;
using DataAccess.Repository;

namespace DataAccess
{
    public class EXPMasterRepository : GenericRepository<EXPMaster>, IEXPMasterRepository
    {
        public EXPMasterRepository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<EXPMaster> IEXPMasterRepository.GetEXPMasterAll() => GetAll().OrderByDescending(e => e.Id);
    }
}