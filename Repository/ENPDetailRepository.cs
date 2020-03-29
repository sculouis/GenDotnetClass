using System.Linq;
using DataAccess.Interfaces;

namespace DataAccess
{
    public class ENPDetailRepository : GenericRepository<ENPDetail>, IENPDetailRepository
    {
        public ENPDetailRepository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<ENPDetail> IENPDetailRepository.GetFormMasterAll() =>
            GetAll().OrderByDescending(e => e.Id);
    }
}