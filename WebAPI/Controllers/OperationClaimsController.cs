using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Core.Entities.Concrete;
using DataAccessLayer.Concrete.NpgsqlEntityFamework;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
    
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimsController : Controller
    {
        IOperationClaimService _operationClaimService;

        public OperationClaimsController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {            
            var result = _operationClaimService.GetAll();
            if (result.Success)
            {
            return Ok(result);
            } 
            return BadRequest(result);
        }
        [HttpGet("get")]
        public IActionResult Get(int id )
        {
            var result = _operationClaimService.GetByID(id);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(OperationClaim operationClaim)
        {
            var result = _operationClaimService.Add(operationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
