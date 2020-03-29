using System.Linq;
using DataAccess.Interfaces;

namespace DataAccess
{
    public class ${TableName}Repository : GenericRepository<${TableName}>, I${TableName}Repository
    {
        public ${TableName}Repository(MyDBContext dncontent):base(dncontent)
        {
        }

        IQueryable<${TableName}> I${TableName}Repository.GetFormMasterAll() =>
            GetAll().OrderByDescending(e => e.Id);
    }
}