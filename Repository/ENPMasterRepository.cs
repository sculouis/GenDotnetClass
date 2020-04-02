using System.Linq;
using DataAccess.Interfaces;
using DataAccess.Repository;

namespace DataAccess
{
    public class ENPMasterRepository : GenericRepository<ENPMaster>, IENPMasterRepository
    {
        public ENPMasterRepository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<ENPMaster> IENPMasterRepository.GetENPMasterAll() => GetAll().OrderByDescending(e => e.Id);
    }
}