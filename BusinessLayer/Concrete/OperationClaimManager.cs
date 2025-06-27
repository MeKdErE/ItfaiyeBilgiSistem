using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccessLayer.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer.Concrete
{
    public class OperationClaimManager : IOperationClaimService        
    {
        IOperationClaimDal _operationClaimDal;

        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public IResult Add(OperationClaim operationClaim)
        {
            _operationClaimDal.Add(operationClaim);
            return new SuccessResult(Messages.OperationClaimAddSuccess);
        }

        public IResult Delete(int Id)
        {
            OperationClaim delOC = _operationClaimDal.Get(oC => oC.Id == Id);
            if (delOC != null) 
            {
            _operationClaimDal.Delete(delOC);
           return new SuccessResult(Messages.OperationClaimDeleteSuccess);
            }
            return new ErrorResult(Messages.OperationClaimDeleteError);
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetAll(),Messages.OperationClaimAllListSuccess);
        }

        public IDataResult<OperationClaim> GetByID(int Id)
        {
            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(oC => oC.Id == Id), Messages.OperationClaimGetByIdSuccess);
        }

        public IDataResult<OperationClaim> GetByName(string name)
        {
            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(oC => oC.Name == name),Messages.OperationClaimGetByNameSuccess);
        }

        public IResult Update(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }
    }
}
