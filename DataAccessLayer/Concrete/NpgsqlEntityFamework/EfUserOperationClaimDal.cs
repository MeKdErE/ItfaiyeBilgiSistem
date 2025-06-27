using Core.DataAccess.Concrete.NpgsqlEntityFrameworks;
using Core.Entities.Concrete;
using DataAccessLayer.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.NpgsqlEntityFamework
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, NpgsqlIbsContext>, IUserOperationClaimDal
    {
    }
}
