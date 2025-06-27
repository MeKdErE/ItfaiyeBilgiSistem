using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using DataAccessLayer.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOperationClaimService
    {
        IResult Add(OperationClaim operationClaim);
        IResult Update(OperationClaim operationClaim);
        IResult Delete(int Id);
        IDataResult<List<OperationClaim>> GetAll();
        IDataResult<OperationClaim> GetByID(int Id);
        IDataResult<OperationClaim> GetByName(string name);
    }
}
