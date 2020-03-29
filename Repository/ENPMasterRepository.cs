using System.Linq;
using DataAccess.Interfaces;

namespace DataAccess
{
    public class ENPMasterRepository : GenericRepository<ENPMaster>, IENPMasterRepository
    {
        public ENPMasterRepository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<ENPMaster> IENPMasterRepository.GetFormMasterAll() =>
            GetAll().OrderByDescending(e => e.Id);
    }
}