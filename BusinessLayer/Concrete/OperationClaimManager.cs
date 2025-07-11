using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using BusinessLayer.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccessLayer.Abstract.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [ValidationAspect(typeof(OperationClaimValidator))]
        public IResult Add(OperationClaim operationClaim)
        {
            if (CheckIfCountOfOperationClaim().Success)
            {
                if (CheckIfOperationClaimNameExists(operationClaim.Name).Success)
                {
                    _operationClaimDal.Add(operationClaim);
                    return new SuccessResult(Messages.OperationClaimAddSuccess);
                }
                return new ErrorResult(Messages.OperationClaimNameAlreadyExists);
            }
                return new ErrorResult(Messages.OperationClaimAddError);
            
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

        private IResult CheckIfCountOfOperationClaim() 
        {
            var result = _operationClaimDal.GetAll().Count;
            if (result >= 7)
            {
                return new ErrorResult(Messages.CountOfOperationCliamsError);
            }
            return new SuccessResult();
        }
        private IResult CheckIfOperationClaimNameExists(string name)
        {
            var result = _operationClaimDal.GetAll(oc => oc.Name == name).Any();
            if (result)
            {
                return new ErrorResult(Messages.OperationClaimNameAlreadyExists);
            }
            return new SuccessResult();
        }


    }
}
